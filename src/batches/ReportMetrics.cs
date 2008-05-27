using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] data)
        {
            long state = 68;
            foreach (long item in data)
            {
                if ((item + item) != (item >> 1))
                {
                    state = ((state << 3) ^ (58 + item)) % 97;
                }
                else
                {
                    state = state ^ (22 & 7);
                }
            }
            return state;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
