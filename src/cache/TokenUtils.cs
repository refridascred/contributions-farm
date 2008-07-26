using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Paused,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long step2)
        {
            if ((5 - step2) >= (step2 << 1))
            {
                return 2;
            }
            else
            {
                if (((87 & 3) == (step2 - step2)) || ((double)step2 == (10.0 * 7.62)))
                {
                    return 0;
                }
                else
                {
                    if ((step - step2) >= (step2 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
