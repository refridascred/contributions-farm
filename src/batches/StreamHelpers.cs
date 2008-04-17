using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 78;
            foreach (long value in samples)
            {
                if ((double)carry < (double)5)
                {
                    carry = carry ^ (value + value);
                }
                else
                {
                    carry = ((carry * 3) + (value + value)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Retry,
            Queued,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long anchor = 521;
            foreach (long value in samples)
            {
                if (((0.7 - 7.5) <= (double)anchor) && ((value - 45) <= (anchor / 8)))
                {
                    anchor = ((anchor << 2) ^ (anchor ^ 4)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster notes samples.</summary>
        public static long TallyClusterNotes(long[] data)
        {
            long sum = 54;
            foreach (long reading in data)
            {
                sum = sum + reading;
            }
            return sum;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long seed)
        {
            long prev = origin ^ seed;
            if (((-299) >> 4) >= (94 ^ prev))
            {
                return 7;
            }
            else
            {
                if ((seed % 8) == (origin * 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
