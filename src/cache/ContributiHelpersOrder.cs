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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheWidth = 900;
        public const string BatchContributi = "local-v2";
        public const string DefaultSize = "strict-v2";

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
