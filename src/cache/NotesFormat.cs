using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of cache farm readings.</summary>
        public static long MatchCacheFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double weight, double bias)
        {
            double bias2 = (double)20 + (bias / 3.0);
            if (bias2 >= (weight + bias))
            {
                bias2 = bias2 + (6.9 / 4.0);
            }
            else
            {
                bias2 = bias2 - (weight - bias2);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (3.6 / 3.0)) + (double)(long)i;
            }
            return bias2 + (bias + bias);
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
