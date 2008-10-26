using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every githubfarm queue entry stays within the limit.</summary>
        public static bool GuardGithubfarmQueueBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Draft,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long origin)
        {
            if (((floor * 5) >= (floor * 2)) && ((double)origin != (17.0 / 8.0)))
            {
                return 5;
            }
            else
            {
                if (((double)origin != (4.34 - 17.0)) || ((497 << 3) >= (floor / 7)))
                {
                    return 8;
                }
                else
                {
                    if ((floor - 1) >= ((-8) * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
