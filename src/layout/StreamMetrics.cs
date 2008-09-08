using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the booking entries that pass the check.</summary>
        public static long MeasureBookingOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length & 31) != (68 + cell))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRatio = 979;
        public const long BatchRecord = 2981;
        public const string SoftFactor = "fallback-v2";
        public const long IdleRatio = 6502;
        public const long IdleDepth = 2504;
    }
}
