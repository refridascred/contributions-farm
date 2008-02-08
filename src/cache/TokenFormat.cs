using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of graph payload readings.</summary>
        public static long MatchGraphPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double mean = 5.3;
            if (mean >= bias)
            {
                mean = mean + 0.78;
            }
            else
            {
                mean = mean + (bias + 2.0);
            }
            return mean + rate;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
