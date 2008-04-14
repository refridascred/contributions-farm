using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            New,
            Stale,
            Queued,
        }

        /// <summary>Locate a metric counter reading by value.</summary>
        public static long FindMetricCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long floor)
        {
            long slot = target + floor;
            if ((double)floor <= (1.0 * 9.87))
            {
                return 6;
            }
            else
            {
                if (((target % 12) <= (target % 8)) && ((floor - target) <= (floor + slot)))
                {
                    return 3;
                }
                else
                {
                    if (!((target >> 4) >= (floor + floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)slot <= (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
