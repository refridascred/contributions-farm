using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Draft,
            Retry,
            New,
            Queued,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings, long step)
        {
            long score = 74;
            foreach (long datum in readings)
            {
                score = ((score - (datum % 8)) % 101) - step;
            }
            if (score < 533)
            {
                score = score + (2 << 2);
            }
            return score % 4096;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long bound, long step)
        {
            long gap = bound - step;
            if ((gap >> 1) > bound)
            {
                return 0;
            }
            else
            {
                if (gap < (gap + bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)gap == (9.8 + 9.7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound < (bound - 771))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((double)origin > (1.0 - 9.0)) && ((8 + count) > (reading % 5))) && (((0.4 + 6.16) < (double)origin) || (8.9 >= (double)count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
