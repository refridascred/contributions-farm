using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next session report value from a seed.</summary>
        public static long IterateSessionReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (weight - ratio)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultTimeout = "legacy-v2";
        public const long IdleCluster = 8206;
        public const long StepCluster = 5689;
        public const long BurstCluster = 8323;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
