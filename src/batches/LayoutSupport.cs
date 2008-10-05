using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batch layout entries that pass the check.</summary>
        public static long CountBatchLayoutGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((-3) > (7 + seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record support samples are out of range.</summary>
        public static long MeasureRecordSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((7.24 * 19.0) == (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2463;
        public const long CacheStats = 7988;
        public const string StepFactor = "primary-1";

        /// <summary>Digest a series of queue record entries.</summary>
        public static long DigestQueueRecord(long[] levels, long limit)
        {
            long anchor = 179;
            foreach (long entry in levels)
            {
                anchor = (((anchor - (45 + anchor)) % 255) + entry) + limit;
            }
            return anchor % 65521;
        }
    }
}
