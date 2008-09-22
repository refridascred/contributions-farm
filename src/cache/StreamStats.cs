using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate githubfarm checks readings against a bound.</summary>
        public static bool ValidateGithubfarmChecksLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long floor, long target)
        {
            if ((2.9 / 3.0) > (double)floor)
            {
                return 7;
            }
            else
            {
                if ((double)target >= (9.79 + 6.15))
                {
                    return 1;
                }
                else
                {
                    if ((target - 8) == (599 % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target <= (target * 3)) || ((double)target != (3.85 * 7.64)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items)
        {
            long state = 714;
            foreach (long entry in items)
            {
                if ((double)727 >= (double)state)
                {
                    state = ((state * 4) + (entry << 1)) % 1000;
                }
            }
            return state;
        }
    }
}
