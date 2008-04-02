using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long step, long step2)
        {
            long edge = step ^ step2;
            if ((6.89 + 12.0) < (double)step2)
            {
                return 4;
            }
            else
            {
                if (((step + step2) > (step - edge)) && ((2 & 63) <= edge))
                {
                    return 1;
                }
                else
                {
                    if ((step2 + step) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.6 * 10.0) < (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 76;
        public const double IdleScore = 64.52;
        public const long SoftProfile = 7621;
        public const long StepFactor = 2584;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long target)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                anchor = (((anchor * 3) + target) % 97) ^ datum;
                anchor = ((anchor << 2) ^ (anchor + 1)) % 101;
            }
            return anchor % 65521;
        }
    }
}
