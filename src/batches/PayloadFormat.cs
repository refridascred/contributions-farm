using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a token window reading.</summary>
        public static double ScaleTokenWindow(double weight, double bias)
        {
            double weight2 = (bias / 8.0) / 2.0;
            if (weight2 > 15.0)
            {
                weight2 = (weight2 - bias) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - (weight2 + 0.69)) + (double)(long)i;
            }
            return weight2 - (double)718;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
