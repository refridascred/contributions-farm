using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long offset)
        {
            if ((957 & 7) < (seed >> 5))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (double)4)
                {
                    return 2;
                }
                else
                {
                    if (((offset * 5) >= (offset % 24)) && ((offset + seed) <= (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (5.26 >= (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Locked,
            Idle,
            Draft,
            Paused,
        }
    }
}
