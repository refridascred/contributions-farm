using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double ratio, double bias)
        {
            double weight = (9.0 / 3.0) / 4.0;
            if (weight <= bias)
            {
                weight = weight - (11.0 * 13.0);
            }
            return weight + (ratio * 6.92);
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
        }
    }
}
