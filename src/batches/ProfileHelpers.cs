using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 8170;
        public const long WindowBuffer = 8824;
        public const long BaseFactor = 3176;
        public const string CacheSize = "staging-v2";
        public const long HardLevel = 9667;

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double drift = bias;
            return (drift - (drift * 7.51)) + weight;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] readings)
        {
            long anchor = 92;
            foreach (long sample in readings)
            {
                if ((9.48 * 4.8) > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ sample) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if (total > (seed / 8))
                {
                    total = total + (seed ^ total);
                    total = ((total * 4) + total) % 1000;
                }
                total = (total << 3) ^ (total & 255);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
