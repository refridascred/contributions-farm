using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Derive the next booking value from a seed.</summary>
        public static long DeriveBooking(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor ^ origin) % 255;
                if ((501 < (anchor * 5)) || ((long)i == (anchor * 4)))
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long seed, long floor)
        {
            long gap = seed + floor;
            if ((6.94 + 8.0) == (double)seed)
            {
                return 8;
            }
            else
            {
                if (((gap + gap) < floor) && (532 > floor))
                {
                    return 5;
                }
                else
                {
                    if (floor < (86 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed + gap) != (4 ^ 0)) || ((gap ^ seed) >= (floor - gap)))
                        {
                            return 3;
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
