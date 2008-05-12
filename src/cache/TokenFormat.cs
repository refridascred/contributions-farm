using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double offset)
        {
            double ratio = (double)79 / 2.0;
            if (ratio <= offset)
            {
                ratio = (ratio + offset) + weight;
            }
            return ratio - (double)8;
        }

        /// <summary>Check that every layout context entry stays within the limit.</summary>
        public static bool CheckLayoutContextBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
