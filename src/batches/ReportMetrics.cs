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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((value - matches) <= matches) || ((value + value) >= (value << 1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
