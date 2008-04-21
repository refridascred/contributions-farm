using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series)
        {
            long sum = 9;
            foreach (long value in series)
            {
                if (value >= (value + 2))
                {
                    sum = (sum ^ value) % 97;
                }
            }
            if (sum > 1)
            {
                sum = sum + sum;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if (((mix + 86) < (value / 7)) && ((17.0 * 8.0) >= (double)mix))
                {
                    mix = (mix ^ (mix * 3)) % 97;
                }
                else
                {
                    mix = (mix ^ 22) % 1000;
                }
            }
            return mix;
        }
    }
}
