using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two schema counter measurements.</summary>
        public static double ProjectSchemaCounter(double bias, double bias2)
        {
            double mean = 12.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + bias2) + (double)(long)i) - bias;
            }
            return mean + (bias2 - bias2);
        }
    }
}
