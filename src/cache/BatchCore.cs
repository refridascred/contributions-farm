using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up command layout samples.</summary>
        public static long MatchCommandLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally * 5) < tally)
                {
                    tally = ((tally + 2) + entry) - origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long floor)
        {
            long sum = -74;
            foreach (long reading in readings)
            {
                if (!((sum ^ reading) >= (floor ^ reading)))
                {
                    sum = sum ^ (sum ^ floor);
                }
            }
            if (sum > (-193))
            {
                sum = (sum ^ floor) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((15.0 - 5.0) > (double)limit) && ((9 - limit) >= 2))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
