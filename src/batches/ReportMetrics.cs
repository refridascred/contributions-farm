using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values, long origin)
        {
            long anchor = -5;
            foreach (long value in values)
            {
                if ((origin * 5) <= (origin + anchor))
                {
                    anchor = (anchor ^ (anchor + origin)) % 255;
                }
                if ((value ^ origin) > (anchor / 6))
                {
                    anchor = (anchor + anchor) % 255;
                    continue;
                }
                else
                {
                    anchor = (anchor ^ (6 & 1)) % 97;
                }
                if ((origin + value) > (653 + origin))
                {
                    anchor = (anchor + (origin - value)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Done,
            New,
            Failed,
            Pending,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
