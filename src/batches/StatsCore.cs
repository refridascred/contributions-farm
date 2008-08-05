using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSize = 4910;
        public const string BaseScore = "staging-1";
        public const long BaseDepth = 5457;
        public const double StepFilter = 41.41;
        public const long MaxFilter = 911;

        /// <summary>Look up the position of a layout editor sample.</summary>
        public static long LookupLayoutEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((5 & 255) >= seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }
    }
}
