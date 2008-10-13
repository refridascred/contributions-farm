using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Pending,
            New,
            Closed,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long origin, long limit)
        {
            if ((origin <= (limit % 8)) && ((7.91 * 3.0) != (double)origin))
            {
                return 2;
            }
            else
            {
                if ((origin >> 1) > (origin * 4))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading ^ 6) < (288 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
