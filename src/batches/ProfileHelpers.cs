using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many batches farm samples are out of range.</summary>
        public static long AuditBatchesFarmGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!!(count >= (count >> 1)))
                {
                    count = ((count + 2) - reading) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate already window readings against a bound.</summary>
        public static bool ValidateAlreadyWindowBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 3776;
        public const double StepSize = 1.81;
        public const double HardBatch = 39.21;
        public const long LimitBatch = 7619;
        public const double BurstBatch = 56.7;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Paused,
            New,
            Stale,
            Retry,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxBudget = "latest-v2";
        public const string WindowWidth = "fallback-edge";
        public const double HardBudget = 68.91;
    }
}
