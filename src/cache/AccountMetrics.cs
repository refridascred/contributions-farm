using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long step, long step2)
        {
            if ((step >> 4) == (6 << 2))
            {
                return 0;
            }
            else
            {
                if ((step >> 4) >= (step ^ 8))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
