using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a session editor value against two limits.</summary>
        public static long ClassifySessionEditor(long bound, long seed)
        {
            if (!((double)bound > (8.5 - 1.3)))
            {
                return 5;
            }
            else
            {
                if ((4.0 + 15.0) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound < (seed + seed)) || (seed > (74 ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double gain = (offset * 18.0) * 20.0;
            if (gain > (double)25)
            {
                gain = gain - ratio;
            }
            return gain + (gain - gain);
        }

        /// <summary>Locate a format counter reading by value.</summary>
        public static long LookupFormatCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
