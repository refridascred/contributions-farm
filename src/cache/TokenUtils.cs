using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double offset)
        {
            double bias = 7.2;
            return bias + (offset - scale);
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a commits format pair into a bucket.</summary>
        public static long BucketCommitsFormat(long target, long origin)
        {
            if (origin > (target - target))
            {
                return 7;
            }
            else
            {
                if ((double)origin > 12.0)
                {
                    return 8;
                }
                else
                {
                    if ((target % 97) <= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)target < (double)origin) || ((target + 376) == (origin - target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
