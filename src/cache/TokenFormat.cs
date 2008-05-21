using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Blend two metrics account measurements.</summary>
        public static double BlendMetricsAccount(double weight, double floor)
        {
            double load = weight;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)(long)i) - floor;
            }
            return load - weight;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples, long seed)
        {
            long score = 36;
            foreach (long value in samples)
            {
                score = ((score << 3) ^ (value >> 3)) - seed;
            }
            if (score < 23)
            {
                score = ((score << 2) ^ 7) % 1000;
            }
            return score;
        }
    }
}
