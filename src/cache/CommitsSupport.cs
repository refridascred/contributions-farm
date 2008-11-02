using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Count the batches session entries that pass the check.</summary>
        public static long MeasureBatchesSessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((615 >> 5) >= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double ratio = floor;
            if (ratio >= floor)
            {
                ratio = ratio - (ratio * 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (rate / 5.0)) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long offset)
        {
            if (((double)offset < (double)step) && (offset > (offset * 4)))
            {
                return 2;
            }
            else
            {
                if ((step - offset) >= offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Region { get; set; }
            public double Label { get; set; }
        }
    }
}
