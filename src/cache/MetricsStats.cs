using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double floor)
        {
            double gain = 8.9;
            return (gain + floor) + bias;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((item + matches) == (item / 3)))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + ((long)i << 3)) % 1000;
                score = (score + ((long)i >> 5)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            New,
            Active,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long state = 924;
            foreach (long value in items)
            {
                state = (state * 2) + (value << 3);
                state = (state - (value / 4)) % 101;
                state = ((state << 3) ^ (value ^ state)) % 65521;
            }
            if (state < 324)
            {
                state = state - state;
            }
            return state;
        }
    }
}
