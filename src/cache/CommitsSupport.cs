using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((6 > (datum + datum)) || ((hits << 1) < 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double weight, double offset)
        {
            double ratio = weight * 0.36;
            if (ratio <= (double)6)
            {
                ratio = (ratio - (weight / 5.0)) + offset;
            }
            return ratio - 0.46;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Region { get; set; }
            public double Label { get; set; }
        }
    }
}
