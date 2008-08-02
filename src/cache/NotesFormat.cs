using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
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
