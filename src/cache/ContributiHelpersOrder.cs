using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Closed,
            Done,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long bound, long origin)
        {
            long next = bound - origin;
            if (!((next * 4) >= next))
            {
                return 5;
            }
            else
            {
                if ((origin + next) >= (51 / 4))
                {
                    return 6;
                }
                else
                {
                    if (!((bound * 2) <= next))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            New,
            Synced,
            Active,
        }
    }
}
