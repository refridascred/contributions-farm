using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many support metrics samples are out of range.</summary>
        public static long AuditSupportMetricsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits / 4) < datum)
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

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data)
        {
            long mix = 5;
            foreach (long entry in data)
            {
                mix = ((mix << 2) ^ (entry % 12)) % 255;
            }
            if (mix < 863)
            {
                mix = ((mix << 2) ^ (mix << 3)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((8.2 / 4.0) == (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Active,
            Queued,
            Stale,
            Retry,
        }
    }
}
