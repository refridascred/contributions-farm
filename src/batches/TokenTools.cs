using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool VerifyQueueGithubfarmBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a contributi entry value against two limits.</summary>
        public static long ClassifyContributiEntry(long offset, long floor)
        {
            if ((8.85 * 6.33) <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (((floor % 5) == (offset << 2)) || ((floor >> 3) < (offset + offset)))
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)floor > (2.0 * 9.63)) || ((double)offset <= 2.28))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
