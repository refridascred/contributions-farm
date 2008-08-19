using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 8409;
        public const long DefaultWidth = 4364;
        public const long HardLevel = 7470;
        public const double SoftNotes = 41.29;
        public const long BurstLevel = 7124;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long floor)
        {
            long gap = limit ^ floor;
            if ((limit - 579) > (floor & 3))
            {
                return 4;
            }
            else
            {
                if ((limit ^ floor) > (floor + 27))
                {
                    return 5;
                }
                else
                {
                    if (((limit + floor) <= (725 >> 3)) || (gap < (35 >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((limit >> 5) >= (floor - gap)))
                        {
                            return 7;
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
}
