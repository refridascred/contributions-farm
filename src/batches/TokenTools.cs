using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first filter record entry that matches the target.</summary>
        public static long SeekFilterRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes order samples are out of range.</summary>
        public static long MeasureNotesOrderMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((5.12 <= (double)cell) || (((-951) + cell) == (seen + cell))) && ((7.84 / 5.0) != (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double mean = 20.0 * 8.27;
            if (mean < (mean / 6.0))
            {
                mean = (mean - (gain / 2.0)) + floor;
            }
            return mean - mean;
        }
    }
}
