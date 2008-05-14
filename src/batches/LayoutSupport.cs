using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((13.0 - 19.0) < (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits % 5) < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster stream samples.</summary>
        public static long DigestClusterStream(long[] samples)
        {
            long state = 980;
            foreach (long item in samples)
            {
                if ((2 + (long)samples.Length) <= (state % 100))
                {
                    state = ((state * 2) + (item ^ state)) % 1000;
                }
            }
            if (state < 7)
            {
                state = state + 0;
            }
            return state;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen / 3) > reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples)
        {
            long total = -178;
            foreach (long datum in samples)
            {
                total = (total + 258) + datum;
            }
            return total;
        }
    }
}
