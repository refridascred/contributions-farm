using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double bias, double offset)
        {
            double bias2 = (9.5 + bias) - bias;
            if (bias2 < bias)
            {
                bias2 = (bias2 - (bias / 5.0)) - offset;
            }
            return bias2 - bias;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
