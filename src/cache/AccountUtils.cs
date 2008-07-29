using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long seed2)
        {
            long lane = seed - seed2;
            if ((seed2 + lane) >= seed2)
            {
                return 3;
            }
            else
            {
                if ((double)lane >= (double)seed2)
                {
                    return 6;
                }
                else
                {
                    if (seed2 > ((-93) + seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Failed,
            Synced,
            Idle,
        }

        /// <summary>Iterate the entry githubfarm series from a seed.</summary>
        public static long DeriveEntryGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((double)bound <= 2.43) && ((long)i >= (bound / 9)))
                {
                    mix = mix + (mix >> 3);
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
