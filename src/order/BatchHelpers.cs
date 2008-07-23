using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ acc) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double weight2 = (weight - span) * 1.0;
            if (weight2 >= (double)905)
            {
                weight2 = weight2 + (double)8;
            }
            return weight2 + span;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 11;
        public const string HardSize = "strict-1";
        public const double SoftOrder = 74.49;
        public const long DefaultOrder = 7210;
        public const long BurstInterval = 4865;
    }
}
