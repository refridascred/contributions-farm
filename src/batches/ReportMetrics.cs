using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Queued,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheDepth = 3.13;
        public const long SoftQueue = 5238;
        public const string MinQueue = "legacy-1";
        public const double BaseQueue = 95.29;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((5 - 48) != (seen - step)) || !((double)634 <= (double)item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
