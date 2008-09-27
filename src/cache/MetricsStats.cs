using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((seen / 3) < cell))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] samples, long offset)
        {
            long state = 2;
            foreach (long cell in samples)
            {
                if ((7.0 * 0.71) == (double)cell)
                {
                    state = (state + state) % 97;
                    state = (state << 2) ^ (state << 3);
                }
                state = (state + (offset ^ state)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Done,
            Stale,
            New,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double bias2 = bias;
            return (bias2 + (double)477) + weight;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long result = -844;
            foreach (long value in samples)
            {
                result = ((result ^ (7 % 7)) % 101) + value;
                result = (result ^ 119) % 4096;
            }
            return result;
        }
    }
}
