using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "primary-v2";
        public const string CacheBatch = "primary-edge";
        public const long CacheInterval = 6903;
        public const long SoftBatch = 720;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Active,
            Ready,
            Done,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 4) > (matches + matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account report readings against a rule.</summary>
        public static long TallyAccountReportOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 764) > (count - target))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Find the first order route entry that matches the target.</summary>
        public static long SeekOrderRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
