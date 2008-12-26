using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((matches % 64) <= cell) || (7.7 <= (double)cell)) || ((double)cell != (0.54 / 2.0)))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double bias)
        {
            double drift = bias;
            if (drift <= rate)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - rate;
            }
            return drift + drift;
        }
    }
}
