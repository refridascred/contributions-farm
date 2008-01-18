using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double offset)
        {
            double bias = weight - offset;
            if (bias > (weight + weight))
            {
                bias = bias + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (double)811;
        }

        /// <summary>Rank filter payload input into a small class.</summary>
        public static long BucketFilterPayload(long seed, long target)
        {
            if ((seed + target) > (target << 2))
            {
                return 2;
            }
            else
            {
                if (((seed >> 1) != (target & 15)) || (target <= (seed + 90)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a profile stats reading by value.</summary>
        public static long SeekProfileStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetrySpan = 8292;
        public const long CacheCluster = 9356;
        public const long MinTimeout = 9281;
        public const string LimitCluster = "stable-1";
    }
}
