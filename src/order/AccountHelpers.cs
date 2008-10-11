using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings, long seed)
        {
            long anchor = 2;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 2) ^ 286) % 65521;
                if ((5.2 * 6.61) == (double)sample)
                {
                    break;
                }
            }
            if (anchor > 929)
            {
                anchor = (anchor * 2) + seed;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Dropped,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Count the metrics tools entries that pass the check.</summary>
        public static long CountMetricsToolsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 8) >= (entry - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSpan = 4947;
        public const string BatchOrder = "latest-v2";
        public const string StepOrder = "strict";
        public const long IdleOrder = 1966;
        public const double BaseLevel = 86.48;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample - count) <= (count / 9))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
