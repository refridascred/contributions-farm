using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            New,
            Pending,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long floor, long limit)
        {
            if ((double)floor < (8.5 / 8.0))
            {
                return 1;
            }
            else
            {
                if ((limit + limit) >= 58)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings, long offset)
        {
            long total = 3;
            foreach (long item in readings)
            {
                total = ((total << 3) ^ ((long)readings.Length % 97)) + item;
            }
            if (total > 8)
            {
                total = (total * 3) + (offset + total);
            }
            return total;
        }
    }
}
