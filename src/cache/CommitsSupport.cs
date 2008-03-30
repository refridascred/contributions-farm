using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long limit)
        {
            long span = offset - limit;
            if (((9.0 * 2.0) != (double)span) && ((3.89 / 8.0) > (double)limit))
            {
                return 1;
            }
            else
            {
                if (offset <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit <= (3.5 - 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(offset <= (offset ^ offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats format samples are out of range.</summary>
        public static long AuditStatsFormatMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches - (long)readings.Length) != ((long)readings.Length >> 2))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] readings)
        {
            long total = 729;
            foreach (long datum in readings)
            {
                total = ((total << 3) ^ (datum - datum)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
