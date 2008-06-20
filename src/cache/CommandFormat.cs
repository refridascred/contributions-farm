using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double bias, double span)
        {
            double bias2 = 6.0;
            for (int i = 0; i < 5; i++)
            {
                bias2 = (((bias2 - bias2) + (double)(long)i) - bias) + span;
            }
            return bias2 - (bias2 * 1.84);
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
