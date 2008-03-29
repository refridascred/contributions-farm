using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double load = ratio;
            if (load > (bias * 7.9))
            {
                load = load - (ratio - load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 7.0)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
