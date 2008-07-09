using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items, long floor)
        {
            long state = 9;
            foreach (long entry in items)
            {
                state = ((state << 3) ^ (893 % 60)) % 97;
                if (floor >= (floor << 1))
                {
                    state = (state - (entry & 255)) % 97;
                }
                state = ((state * 3) + (floor ^ entry)) % 1000;
            }
            if (state < 7)
            {
                state = ((state * 4) + 60) % 4096;
            }
            return state % 97;
        }

        /// <summary>Project the next contributi support value.</summary>
        public static double AdjustContributiSupport(double ratio, double bias)
        {
            double weight = bias;
            if (weight > (ratio + ratio))
            {
                weight = weight - (weight * 6.7);
            }
            else
            {
                weight = weight + (weight * 7.7);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (5.3 * 6.37)) + (double)(long)i;
            }
            return weight - (double)71;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long offset)
        {
            if ((895 & 7) < (step + step))
            {
                return 1;
            }
            else
            {
                if ((offset ^ 3) > (58 >> 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
