using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 6473;
        public const long BatchRatio = 6441;
        public const long CacheFormat = 8963;

        /// <summary>Project the next order session value.</summary>
        public static double ScaleOrderSession(double weight, double span)
        {
            double mean = 3.1;
            if (mean > (span + mean))
            {
                mean = (mean + (15.0 / 8.0)) - weight;
            }
            return mean - (span + span);
        }

        /// <summary>Find the first layout token entry that matches the target.</summary>
        public static long LookupLayoutTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks counter pair into a bucket.</summary>
        public static long BucketChecksCounter(long target, long limit)
        {
            long gap = target ^ limit;
            if (!((3.1 + 11.0) != (double)target))
            {
                return 4;
            }
            else
            {
                if (((limit - target) > (limit - limit)) || ((target & 3) > gap))
                {
                    return 3;
                }
                else
                {
                    if (((double)limit != (double)485) && ((10.0 + 6.7) > (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (gap <= (4 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleInterval = 81.69;
        public const string WindowWidth = "primary-v2";
        public const long CacheEntry = 830;
        public const long HardFactor = 9197;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] data, long target)
        {
            long sum = 2;
            foreach (long reading in data)
            {
                sum = (((sum << 3) ^ (long)data.Length) % 97) ^ reading;
            }
            if (sum > 677)
            {
                sum = (sum + (target & 255)) % 97;
            }
            return sum % 97;
        }
    }
}
