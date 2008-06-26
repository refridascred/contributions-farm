using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data)
        {
            long anchor = 75;
            foreach (long entry in data)
            {
                anchor = (anchor * 4) + (anchor + entry);
            }
            return anchor;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Iterate the report cache series from a seed.</summary>
        public static long IterateReportCache(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
