using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)79 <= (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series, long seed)
        {
            long mark = 68;
            foreach (long value in series)
            {
                if (!(seed < (108 + seed)))
                {
                    mark = ((mark << 2) ^ mark) ^ value;
                }
                else
                {
                    mark = mark + seed;
                }
            }
            if (mark > 709)
            {
                mark = (mark ^ (seed - 47)) % 101;
            }
            return mark;
        }
    }
}
