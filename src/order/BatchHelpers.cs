using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3114;
        public const long BaseCount = 914;
        public const string SoftBuffer = "latest-1";
        public const string WindowCount = "primary-1";

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long step)
        {
            long slot = target - step;
            if (((slot - step) < step) || (target < (target * 4)))
            {
                return 4;
            }
            else
            {
                if (!((4.6 + 16.0) != (double)slot))
                {
                    return 6;
                }
                else
                {
                    if (((slot + step) < slot) && ((5.1 / 4.0) != (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
