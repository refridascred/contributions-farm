using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits / 7) < offset)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Done,
            Active,
            Ready,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double bias = (double)3 / 2.0;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - bias) + (double)(long)i) + ratio) + offset;
            }
            return bias - 8.0;
        }
    }
}
