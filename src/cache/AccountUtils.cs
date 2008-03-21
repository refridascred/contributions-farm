using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a cache filter pair into a bucket.</summary>
        public static long BucketCacheFilter(long target, long step)
        {
            if ((step - step) <= target)
            {
                return 4;
            }
            else
            {
                if (((double)target >= (7.43 * 4.92)) || ((target + target) < step))
                {
                    return 3;
                }
                else
                {
                    if ((554 - step) >= (target + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target >> 3) < (step % 97))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
