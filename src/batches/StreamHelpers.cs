using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long floor)
        {
            long lane = limit ^ floor;
            if ((floor ^ limit) != (limit + lane))
            {
                return 5;
            }
            else
            {
                if ((8.16 <= (9.8 - 3.1)) && (limit < 713))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((1.4 + 4.68) > (double)hits) || ((hits * 2) > limit))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Failed,
            Pending,
            Stale,
        }
    }
}
