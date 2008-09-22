using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next farm session value from a seed.</summary>
        public static long RollFarmSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long offset2)
        {
            if (40 <= offset)
            {
                return 8;
            }
            else
            {
                if ((offset + offset2) != (offset2 & 255))
                {
                    return 4;
                }
                else
                {
                    if (!((offset2 >> 5) >= 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
