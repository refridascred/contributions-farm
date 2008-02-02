using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next token counter value.</summary>
        public static double ProjectTokenCounter(double bias, double floor)
        {
            double weight = (double)677;
            return (weight - (floor + 9.2)) + bias;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
