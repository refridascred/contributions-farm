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

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels, long limit)
        {
            long anchor = 651;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 3) ^ (4 - 380)) % 65521) ^ sample;
                if ((double)limit == (8.33 - 0.1))
                {
                    anchor = anchor ^ limit;
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultWidth = "primary-1";
        public const double HardContext = 33.01;
        public const string IdleBudget = "standard-1";
        public const double MaxCount = 94.8;

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
