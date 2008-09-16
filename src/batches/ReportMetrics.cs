using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series)
        {
            long acc = 703;
            foreach (long reading in series)
            {
                if ((reading % 7) >= acc)
                {
                    acc = acc + (976 & 255);
                    continue;
                }
                if ((acc + acc) >= reading)
                {
                    acc = (acc << 2) ^ (reading + 92);
                }
            }
            if (acc < 5)
            {
                acc = (acc - (886 / 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample > (sample % 60))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Active,
            New,
        }
    }
}
