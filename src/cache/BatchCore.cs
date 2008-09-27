using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits % 16) > (hits + (-68)))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen & 63) < seen)
                {
                    seen = ((seen + 2) ^ sample) + target;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of contributi editor readings.</summary>
        public static long CompareContributiEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}
