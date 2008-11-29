using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double bias, double offset)
        {
            double rate = bias;
            if (rate >= (0.99 * 12.0))
            {
                rate = (rate + (double)61) - offset;
            }
            return rate + 6.4;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count * 4) <= (count + count))
                {
                    count = ((count + 3) + entry) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }
    }
}
