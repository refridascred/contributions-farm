using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next cache tools value.</summary>
        public static double SmoothCacheTools(double rate, double span)
        {
            double rate2 = (0.83 + 3.6) / 3.0;
            if (rate2 > (2.2 - 2.3))
            {
                rate2 = ((rate2 - rate2) + rate) - span;
            }
            return rate2 + 3.9;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Ready,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Measure how many queue metric samples are out of range.</summary>
        public static long TallyQueueMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits & 255) > (hits ^ hits))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }
    }
}
