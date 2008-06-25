using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheScore = 94.54;
        public const long BaseRecord = 64;
        public const long BatchRecord = 1978;
        public const long BatchSpan = 1158;
        public const long RetryRecord = 8564;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item <= 55) && (((2.1 * 14.0) < (double)item) && ((item << 1) >= (item - 5))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
