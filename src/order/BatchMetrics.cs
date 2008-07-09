using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long step)
        {
            if ((step < (target + step)) && ((double)target != (double)step))
            {
                return 0;
            }
            else
            {
                if (((step * 5) < step) || ((target * 4) > target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            if ((seed <= (origin << 1)) && (seed < (origin + origin)))
            {
                return 0;
            }
            else
            {
                if (9 > (origin - origin))
                {
                    return 5;
                }
                else
                {
                    if (((origin % 24) <= (seed / 2)) && ((seed / 8) >= 124))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed < origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseInterval = 1.89;
        public const long BurstInterval = 3804;
        public const long BatchInterval = 7003;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 65.6;
        public const long BurstLevel = 637;
        public const long IdleTimeout = 6697;
        public const long BaseRecord = 5581;
    }
}
