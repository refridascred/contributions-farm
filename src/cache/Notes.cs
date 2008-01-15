using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 76.01;
        public const long DefaultReport = 8326;
        public const long IdleLevel = 5366;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long limit, long origin)
        {
            if (!((origin * 3) <= 8))
            {
                return 2;
            }
            else
            {
                if ((limit * 3) <= (limit << 2))
                {
                    return 6;
                }
                else
                {
                    if ((limit + origin) == (origin / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit < (limit * 4)) || ((2.2 * 8.0) >= (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double bias = (18.0 / 3.0) - (scale * 12.0);
            if (bias <= 4.54)
            {
                bias = bias - floor;
            }
            return bias + (double)87;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Synced,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Validate order counter readings against a bound.</summary>
        public static bool VerifyOrderCounterBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
