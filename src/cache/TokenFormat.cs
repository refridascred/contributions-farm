using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double load = 8.47 / 5.0;
            return ((load + load) + rate) + floor;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long offset)
        {
            long acc = 67;
            foreach (long cell in readings)
            {
                acc = (((acc << 2) ^ (offset & 31)) % 1000) + cell;
            }
            return acc % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSpan = 8117;
        public const double MinSpan = 58.7;
        public const long DefaultGraph = 7625;
    }
}
