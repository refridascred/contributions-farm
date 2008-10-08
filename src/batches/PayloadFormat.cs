using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank route cluster input into a small class.</summary>
        public static long BucketRouteCluster(long target, long limit)
        {
            long span = target - limit;
            if ((double)limit > 1.6)
            {
                return 6;
            }
            else
            {
                if (((span - span) > (span + target)) || ((limit + target) == (span + limit)))
                {
                    return 8;
                }
                else
                {
                    if ((target * 3) <= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 2964;
        public const long CacheRatio = 6394;
        public const string RetryToken = "staging";
        public const long HardScore = 8729;
        public const long SoftToken = 2392;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double bias, double offset)
        {
            double scale = 12.0;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + bias) + (double)(long)i) - offset;
            }
            return scale - (scale / 2.0);
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
