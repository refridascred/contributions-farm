using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long floor, long origin)
        {
            if (!((floor ^ origin) != (825 + floor)))
            {
                return 2;
            }
            else
            {
                if ((floor - origin) > floor)
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin) < (origin - origin)) || ((double)floor == (0.38 + 2.8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (ratio + ratio2))
            {
                ratio2 = ratio2 + (ratio2 * 6.62);
            }
            return ratio2 - (double)785;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
