using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up order buffer samples.</summary>
        public static long PairOrderBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample < (5.7 * 9.3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample / 3) <= (sample + tally))
                {
                    tally = (tally + 3) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
