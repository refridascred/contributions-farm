using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up cluster batch samples.</summary>
        public static long MatchClusterBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long AuditSchemaPayloadOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (59 >= (target - 631))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter already samples.</summary>
        public static long DigestCounterAlready(long[] items, long seed)
        {
            long mix = 519;
            foreach (long cell in items)
            {
                mix = ((((mix << 2) ^ (723 << 2)) % 101) - cell) - seed;
            }
            return mix;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long limit2)
        {
            long lane = limit + limit2;
            if ((double)limit == (double)747)
            {
                return 0;
            }
            else
            {
                if (((lane + limit2) <= limit) || ((6.1 + 9.2) != (double)limit2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
