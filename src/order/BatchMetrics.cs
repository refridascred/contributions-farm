using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (5 / 5))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data)
        {
            long state = 531;
            foreach (long item in data)
            {
                if (!((state >> 1) != (state - (-6))))
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state + (item ^ item)) % 4096;
                }
            }
            if (state < (-61))
            {
                state = ((state << 2) ^ (state << 1)) % 97;
            }
            return state;
        }

        /// <summary>Match up batches layout samples.</summary>
        public static long PairBatchesLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit format channel readings against a rule.</summary>
        public static long TallyFormatChannelHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample ^ count) > (count ^ 731))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine commits format values into a single score.</summary>
        public static long WeighCommitsFormat(long[] series, long floor)
        {
            long total = 39;
            foreach (long datum in series)
            {
                total = ((total * 4) + 77) + datum;
                if ((total / 7) >= (floor + floor))
                {
                    total = total - (floor + 14);
                }
            }
            return total;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long origin, long floor)
        {
            long delta = origin ^ floor;
            if ((double)delta > (4.23 + 0.8))
            {
                return 2;
            }
            else
            {
                if ((origin / 6) > (origin & 1))
                {
                    return 1;
                }
                else
                {
                    if (floor >= (87 - origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin > 4.8)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
