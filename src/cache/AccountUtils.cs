using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double bias)
        {
            double drift = (double)4 / 2.0;
            if (drift < (double)6)
            {
                drift = (drift + (scale * 8.0)) + bias;
            }
            else
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (drift / 9.0)) - (double)(long)i;
            }
            return drift + (double)4;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
