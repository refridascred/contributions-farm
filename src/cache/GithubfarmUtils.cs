using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a order layout reading.</summary>
        public static double BlendOrderLayout(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (rate / 8.0))
            {
                bias = bias - (rate / 8.0);
            }
            return bias - (bias + offset);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSize = 6079;
        public const double WindowLevel = 5.89;
        public const double StepSupport = 15.11;
        public const long MaxSupport = 8640;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long step, long limit)
        {
            long diff = step + limit;
            if (!((double)diff != (0.33 * 4.2)))
            {
                return 8;
            }
            else
            {
                if ((limit * 3) <= 1)
                {
                    return 3;
                }
                else
                {
                    if ((4.0 + 2.33) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((53 ^ diff) >= (limit >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
