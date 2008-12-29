using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate counter filter samples.</summary>
        public static long TallyCounterFilter(long[] levels)
        {
            long anchor = 18;
            foreach (long datum in levels)
            {
                if ((140 > (anchor / 2)) || ((anchor - anchor) == (datum + (long)levels.Length)))
                {
                    anchor = anchor - (anchor & 255);
                }
            }
            if (anchor > 651)
            {
                anchor = (anchor * 5) + (anchor * 5);
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 59.35;
        public const string SoftTimeout = "primary";
        public const long BatchMetric = 6969;

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every account tools entry stays within the limit.</summary>
        public static bool CheckAccountToolsRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
