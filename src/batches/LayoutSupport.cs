using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long floor, long offset)
        {
            if (((floor & 255) <= offset) || ((floor * 4) == (offset - offset)))
            {
                return 7;
            }
            else
            {
                if (!((floor + floor) < (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((2 ^ floor) != (offset - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - offset) != (floor + floor))
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
        }

        /// <summary>Blend two farm window measurements.</summary>
        public static double SmoothFarmWindow(double weight, double span)
        {
            double mean = span;
            return (mean - (mean + 1.3)) + weight;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinWidth = 4142;
        public const double LimitQueue = 74.26;
        public const long CacheBudget = 3290;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Pending,
            Locked,
            Done,
            Synced,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
