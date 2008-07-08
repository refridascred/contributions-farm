using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (double)89) + (double)(long)i) + gain;
            }
            return scale - floor;
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
