using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
