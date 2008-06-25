using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 2919;
        public const long LimitSession = 8104;
        public const long MaxSession = 5387;
        public const string HardLevel = "stable-1";
        public const string BaseSize = "open-1";

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((33 >= (reading + (-1))) || ((3 ^ 1) <= (floor * 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
