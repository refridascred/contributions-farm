using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item * 5) == (item + item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream token entries that pass the check.</summary>
        public static long TallyStreamTokenHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= 17.0)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryScore = 55.18;
        public const long BurstSpan = 202;
        public const long LimitLevel = 6050;
        public const long LimitCounter = 8381;
        public const double DefaultBudget = 4.81;
    }
}
