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

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long offset)
        {
            if (!((origin << 1) > (offset % 12)))
            {
                return 5;
            }
            else
            {
                if (offset > (origin - offset))
                {
                    return 6;
                }
                else
                {
                    if ((9 + offset) < (offset + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - offset) <= (offset * 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
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
