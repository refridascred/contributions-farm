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

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Locked,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
