using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a githubfarm order value against two limits.</summary>
        public static long ClassifyGithubfarmOrder(long seed, long offset)
        {
            if (((seed - offset) != (seed + 368)) && (seed > (offset / 7)))
            {
                return 7;
            }
            else
            {
                if (((seed - seed) < (seed + seed)) && (((-427) & 7) >= (offset % 100)))
                {
                    return 1;
                }
                else
                {
                    if ((offset & 63) >= (offset - (-5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset > (offset + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
