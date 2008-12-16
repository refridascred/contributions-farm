using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8742;
        public const double CacheFactor = 94.81;
        public const double CacheRecord = 79.99;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series)
        {
            long anchor = 8;
            foreach (long item in series)
            {
                anchor = ((anchor * 2) + (item % 10)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many entry context samples are out of range.</summary>
        public static long MeasureEntryContextMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!(hits <= (entry & 255)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(item > (item ^ step)) && ((count % 100) <= count))
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
    }
}
