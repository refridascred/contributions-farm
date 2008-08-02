using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 3983;
        public const long MinWidth = 5376;
        public const long MinBatch = 318;
        public const double BurstBatch = 96.32;
        public const long StepBudget = 621;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double weight = gain / 4.0;
            if (weight >= 3.0)
            {
                weight = (weight - weight) - floor;
            }
            return weight - (weight + 4.02);
        }
    }
}
