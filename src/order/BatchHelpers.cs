using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 5694;
        public const long CacheEditor = 6337;
        public const long DefaultEditor = 8183;
        public const double IdleInterval = 7.43;

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long offset)
        {
            long lane = limit + offset;
            if ((2.9 / 6.0) != (double)offset)
            {
                return 5;
            }
            else
            {
                if (!((double)lane >= (3.0 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (((lane >> 1) > (0 << 1)) && ((double)limit >= (double)lane))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)lane > (3.3 + 5.16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
