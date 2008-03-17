using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many report window samples are out of range.</summary>
        public static long CountReportWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((18.0 * 8.8) != (double)cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double gain = (double)((-535) / 8);
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (9.84 - weight)) + (double)(long)i) - bias;
            }
            return gain - 19.0;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
