using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double rate = gain + (double)92;
            if (rate >= (rate - floor))
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate - (7.53 + rate);
            }
            return rate + gain;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 95.03;
        public const long MinEntry = 6304;
        public const long StepSpan = 1;
        public const string BurstTimeout = "fallback";

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = mark - origin;
                if (!((double)mark < (7.62 - 2.87)))
                {
                    mark = ((mark << 3) ^ ((long)i << 2)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
