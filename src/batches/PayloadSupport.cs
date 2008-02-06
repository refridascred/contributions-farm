using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long step)
        {
            long step2 = seed + step;
            if ((seed << 1) < (6 * 2))
            {
                return 4;
            }
            else
            {
                if (((step + step) >= step) || ((seed + step2) <= step2))
                {
                    return 5;
                }
                else
                {
                    if (step2 < (seed ^ step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((8 + step2) != (seed + step)) || ((seed ^ seed) >= (step - step2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
