using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long offset)
        {
            long offset2 = seed - offset;
            if ((seed * 4) < (seed >> 2))
            {
                return 5;
            }
            else
            {
                if ((offset + 314) < offset)
                {
                    return 1;
                }
                else
                {
                    if ((seed - offset) == (offset2 ^ offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset2 - seed) == (541 << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 3321;
        public const double StepLevel = 18.87;
        public const double WindowFactor = 23.19;
        public const string BaseContext = "primary";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long bound, long target)
        {
            long delta = bound ^ target;
            if ((delta - bound) > 748)
            {
                return 5;
            }
            else
            {
                if (((target - 95) >= target) && (9.0 > (double)bound))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Queued,
            Ready,
        }
    }
}
