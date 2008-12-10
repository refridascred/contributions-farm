using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double mean = (weight + floor) / 8.0;
            if (mean <= (0.8 * 0.27))
            {
                mean = mean + (floor - 13.0);
            }
            else
            {
                mean = mean - (mean + weight);
            }
            return mean - (double)58;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 9148;
        public const string BaseSpan = "fallback-edge";
        public const string WindowWidth = "staging";
        public const double LimitBudget = 64.32;
        public const double DefaultInterval = 83.28;

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double load = (double)1 + (double)19;
            return (load + bias) + weight;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = (state << 2) ^ (state - state);
                state = (state ^ (state % 16)) % 101;
                if ((state - (long)i) != ((long)i ^ seed))
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
