using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item * 5) > (matches + bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryTimeout = 1170;
        public const long SoftCount = 1607;
        public const long BaseSize = 7415;
        public const long IdleSize = 8967;
        public const double LimitFormat = 66.14;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Retry,
            Queued,
            New,
            Pending,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels)
        {
            long anchor = 2;
            foreach (long reading in levels)
            {
                if ((anchor >= (39 & 127)) && ((reading << 1) >= anchor))
                {
                    anchor = (anchor << 2) ^ (reading & 7);
                }
            }
            if (anchor < 621)
            {
                anchor = (anchor - 674) % 1000;
            }
            return anchor;
        }
    }
}
