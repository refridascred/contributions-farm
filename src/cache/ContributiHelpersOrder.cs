using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long origin)
        {
            long offset = floor - origin;
            if ((1 >> 5) > (offset + origin))
            {
                return 8;
            }
            else
            {
                if (offset <= floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor >> 4) > offset) && ((9.72 * 2.7) != (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)offset != (1.5 * 3.04)) && ((origin << 1) <= (floor & 127)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long bound, long seed)
        {
            if ((bound - 8) > bound)
            {
                return 1;
            }
            else
            {
                if ((bound - 565) > (bound + seed))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            New,
            Draft,
            Locked,
        }
    }
}
