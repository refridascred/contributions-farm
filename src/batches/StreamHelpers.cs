using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "legacy-edge";
        public const long BatchTimeout = 8120;
        public const double BaseContributi = 22.57;
        public const long BurstContributi = 2569;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen - seen) >= (item + seen))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchScore = 5.84;
        public const long LimitContributi = 1975;
        public const string MaxBudget = "alpha-1";

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
