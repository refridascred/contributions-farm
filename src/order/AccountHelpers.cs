using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long target2)
        {
            long slot = target ^ target2;
            if ((target2 - target) > target2)
            {
                return 0;
            }
            else
            {
                if (!(target > (target + slot)))
                {
                    return 3;
                }
                else
                {
                    if (((-82) + target2) == (slot + slot))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long origin, long floor)
        {
            if ((14 ^ origin) < (floor ^ floor))
            {
                return 5;
            }
            else
            {
                if (((origin / 6) == (origin ^ 9)) && ((origin >> 3) == (40 - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 + 5.19) != (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first batch layout entry that matches the target.</summary>
        public static long LookupBatchLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a queue token sample.</summary>
        public static long FindQueueTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 76.65;
        public const long BurstFactor = 229;
        public const long BaseWindow = 9215;
    }
}
