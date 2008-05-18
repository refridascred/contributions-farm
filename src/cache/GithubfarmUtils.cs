using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a cluster route pair into a bucket.</summary>
        public static long ClassifyClusterRoute(long seed, long target)
        {
            long next = seed ^ target;
            if ((424 < (seed << 3)) || ((2.3 * 17.0) == (double)seed))
            {
                return 5;
            }
            else
            {
                if (((seed << 3) <= (next + target)) && ((double)seed >= (double)3))
                {
                    return 8;
                }
                else
                {
                    if ((target + next) >= next)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target - target) > seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Paused,
            Active,
        }
    }
}
