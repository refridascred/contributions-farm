using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Closed,
            Done,
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double offset)
        {
            double weight = 13.0 * 9.9;
            if (weight <= offset)
            {
                weight = (weight - 6.19) - rate;
            }
            return weight + offset;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 3) ^ origin;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double bias)
        {
            double load = (ratio / 4.0) + ratio;
            return load - bias;
        }
    }
}
