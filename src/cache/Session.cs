using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double weight, double floor)
        {
            double rate = weight;
            if (rate > (floor - weight))
            {
                rate = rate + floor;
            }
            return rate + (2.0 - floor);
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            if (((437 >> 1) > bound) || ((origin + bound) != (685 - bound)))
            {
                return 2;
            }
            else
            {
                if (((double)bound < 9.0) && ((7.9 * 4.0) > (double)bound))
                {
                    return 1;
                }
                else
                {
                    if (797 > (bound - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-455) + origin) < (534 % 64))
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
        }
    }
}
