using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two token batch measurements.</summary>
        public static double SmoothTokenBatch(double weight, double span)
        {
            double rate = (double)(285 - 453);
            if (rate <= span)
            {
                rate = (rate - (span * 9.0)) + weight;
            }
            return rate + span;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long state = 21;
            foreach (long reading in data)
            {
                if (!((reading * 2) > (state >> 1)))
                {
                    state = ((state << 2) ^ (reading ^ state)) % 255;
                }
                if (state >= (20 ^ reading))
                {
                    state = state - (248 * 4);
                }
                else
                {
                    state = state - state;
                }
                if ((long)data.Length <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Match up batch filter samples.</summary>
        public static long PairBatchFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first window graph entry that matches the target.</summary>
        public static long LookupWindowGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
