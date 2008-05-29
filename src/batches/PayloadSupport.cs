using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long bound)
        {
            long edge = target ^ bound;
            if (edge >= (422 ^ bound))
            {
                return 4;
            }
            else
            {
                if (174 > target)
                {
                    return 2;
                }
                else
                {
                    if (((target ^ target) == (edge + edge)) && ((edge >> 1) > bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((-10) >= target))
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
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double scale = offset;
            if (scale <= (rate * 9.87))
            {
                scale = scale - (3.4 * 5.8);
            }
            else
            {
                scale = scale - offset;
            }
            return scale - scale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxRatio = 64.79;
        public const double SoftGithubfarm = 37.02;
        public const long BurstSpan = 7663;
        public const long CacheRatio = 1592;
    }
}
