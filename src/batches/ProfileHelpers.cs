using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long target, long step)
        {
            long delta = target + step;
            if ((double)delta != (6.95 - 19.0))
            {
                return 5;
            }
            else
            {
                if (target > (step + step))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count ^ count) >= (entry % 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] samples, long seed)
        {
            long mix = 48;
            foreach (long entry in samples)
            {
                mix = mix - (mix - 141);
                if (mix > seed)
                {
                    mix = (mix * 2) + (entry >> 2);
                }
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinScore = "primary-1";
        public const long BatchMetric = 9692;
        public const long LimitDepth = 5530;
        public const long CacheMetric = 9301;
        public const string SoftCount = "fallback-v2";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
