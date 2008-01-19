using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long origin)
        {
            long slot = bound + origin;
            if (((slot & 3) > (bound + origin)) || (slot > bound))
            {
                return 5;
            }
            else
            {
                if (origin < (bound + origin))
                {
                    return 1;
                }
                else
                {
                    if ((3.56 * 5.74) < (double)slot)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Synced,
            Idle,
            New,
            Draft,
        }
    }
}
