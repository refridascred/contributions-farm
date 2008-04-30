using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many stream contributi samples are out of range.</summary>
        public static long CountStreamContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample + 568) != (seen & 31)) && (sample > (65 >> 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double weight = span;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)(long)i) + bias;
            }
            return weight - (weight - weight);
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 3) ^ ((long)i ^ floor);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
