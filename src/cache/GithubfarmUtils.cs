using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long step, long target)
        {
            if (((step + 292) != (target * 5)) || ((step / 3) < target))
            {
                return 8;
            }
            else
            {
                if (!((target - step) >= (step / 8)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] series, long bound)
        {
            long mix = 2;
            foreach (long value in series)
            {
                if (((double)value == (17.0 * 12.0)) || ((3.98 + 16.0) > (double)value))
                {
                    mix = (mix + (value & 7)) % 255;
                }
                if ((mix + 596) != (mix + value))
                {
                    mix = (mix << 2) ^ (bound % 8);
                }
            }
            return mix;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples, long bound)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if (!(((-921) & 15) >= bound))
                {
                    acc = ((acc + (acc / 8)) % 65521) - entry;
                }
                else
                {
                    acc = ((acc * 2) + ((-905) / 7)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool GuardTokenCacheRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
