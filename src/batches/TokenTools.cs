using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a batches contributi figure with a bias.</summary>
        public static double ProjectBatchesContributi(double weight, double bias)
        {
            double rate = (bias * 0.35) * 3.84;
            if (rate < (weight * 20.0))
            {
                rate = rate - rate;
            }
            return rate + (double)34;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public bool Rank { get; set; }
        }
    }
}
