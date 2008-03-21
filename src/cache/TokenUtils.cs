using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry % 100) >= hits) || (entry > (hits / 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen != (3.2 + 3.3))
                {
                    seen = ((seen + 3) + reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item < (779 + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
