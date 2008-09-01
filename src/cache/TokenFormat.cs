using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double weight = bias;
            if (weight > (18.0 * 8.0))
            {
                weight = (weight - bias) - rate;
            }
            else
            {
                weight = weight - (3.77 - bias);
            }
            return weight + weight;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
