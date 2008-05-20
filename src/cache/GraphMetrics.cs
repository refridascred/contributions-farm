using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((limit <= (9 + entry)) || ((23 + tally) == (entry << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data, long offset)
        {
            long total = 435;
            foreach (long entry in data)
            {
                if ((83 - offset) > (726 << 2))
                {
                    total = ((total - 1) % 101) + entry;
                }
            }
            return total;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long sum = 74;
            foreach (long item in values)
            {
                sum = (((sum * 2) + (0 + seed)) % 101) ^ item;
            }
            if (sum < 62)
            {
                sum = (sum - (seed + sum)) % 1000;
            }
            return sum;
        }
    }
}
