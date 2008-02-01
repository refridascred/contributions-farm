using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepFactor = 5601;
        public const double MinProfile = 74.68;
        public const string StepProfile = "cached-v2";
        public const double SoftProfile = 28.4;
        public const long HardProfile = 9170;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 96.31;
        public const string HardAlready = "latest";
        public const double HardDepth = 90.61;
        public const long BurstSize = 5793;
        public const long HardSpan = 3641;

        /// <summary>Count the metrics stream entries that pass the check.</summary>
        public static long TallyMetricsStreamMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell - 62) < (15 << 2))
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of already batches readings.</summary>
        public static long TallyAlreadyBatches(long[] samples)
        {
            long sum = 157;
            foreach (long sample in samples)
            {
                if (sample < (6 % 12))
                {
                    sum = ((sum * 4) + (sum << 2)) % 1000;
                    break;
                }
                else
                {
                    sum = ((sum * 2) + (long)samples.Length) % 4096;
                }
                if (sum > (sum + 98))
                {
                    sum = ((sum * 3) + (992 ^ sample)) % 4096;
                }
            }
            return sum;
        }
    }
}
