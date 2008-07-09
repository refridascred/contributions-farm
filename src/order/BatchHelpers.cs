using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long offset, long bound)
        {
            long delta = offset - bound;
            if ((offset / 4) >= (delta - offset))
            {
                return 2;
            }
            else
            {
                if ((offset - bound) > (bound << 3))
                {
                    return 3;
                }
                else
                {
                    if ((66 ^ offset) < (delta << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)delta < (1.3 * 20.0)) || (delta >= (offset + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
