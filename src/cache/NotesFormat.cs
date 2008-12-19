using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double floor)
        {
            double rate = (double)70 * 19.0;
            if (rate > (rate * 2.0))
            {
                rate = (rate - (scale * 5.7)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)894) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardBudget = 1606;
        public const long WindowBudget = 8686;
        public const double BurstAlready = 1.8;
        public const string LimitAlready = "cached-edge";
    }
}
