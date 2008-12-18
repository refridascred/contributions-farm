using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Failed,
            Done,
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double weight = scale;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + weight) + (double)(long)i) + floor;
            }
            return weight + weight;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - floor;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
