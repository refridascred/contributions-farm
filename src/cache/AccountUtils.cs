using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double scale = (double)(9 + 338);
            return ((scale + (double)79) + weight) + floor;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long carry = 130;
            foreach (long sample in readings)
            {
                carry = (carry ^ 3) - sample;
            }
            if (carry < (-54))
            {
                carry = (carry - (carry + 97)) % 4096;
            }
            return carry % 1000;
        }
    }
}
