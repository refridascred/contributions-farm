using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] data)
        {
            long total = 73;
            foreach (long reading in data)
            {
                total = ((total + (total + 95)) % 1000) + reading;
            }
            if (total > 454)
            {
                total = ((total << 3) ^ (total << 3)) % 101;
            }
            return total;
        }

        /// <summary>Project the next command stream value.</summary>
        public static double AdjustCommandStream(double weight, double floor)
        {
            double load = weight * 3.84;
            if (load <= weight)
            {
                load = (load + (double)575) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (weight - 4.68);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 2254;
        public const double IdleRatio = 24.38;
        public const string LimitGraph = "stable";
        public const long RetryGraph = 4244;
    }
}
