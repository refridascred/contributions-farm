using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 1019;
        public const long SoftQueue = 5915;
        public const long IdleTimeout = 4539;
        public const long LimitQueue = 1126;
        public const long CacheQueue = 2082;

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total - total) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long bound)
        {
            if (((bound % 8) > (step << 1)) || ((bound << 1) == (54 + step)))
            {
                return 2;
            }
            else
            {
                if (!((double)66 >= (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (((bound << 3) <= step) && ((step + bound) != (bound - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound <= (step & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
