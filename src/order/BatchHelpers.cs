using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "staging";
        public const double MinSpan = 29.07;
        public const double MaxRatio = 88.04;
        public const long CacheBatch = 587;

        /// <summary>Measure how many layout entry samples are out of range.</summary>
        public static long MeasureLayoutEntryGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value % 10) < value)
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
