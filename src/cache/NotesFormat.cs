using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double gain, double floor)
        {
            double drift = floor / 4.0;
            if (drift > floor)
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowInterval = 7518;
        public const long DefaultEntry = 9406;
        public const string BaseCount = "fallback";
        public const long DefaultTimeout = 3313;
    }
}
