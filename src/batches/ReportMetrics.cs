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

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items, long floor)
        {
            long sum = 18;
            foreach (long value in items)
            {
                if (sum >= ((-4) * 5))
                {
                    sum = ((sum ^ floor) % 4096) + value;
                }
                else
                {
                    sum = (sum ^ (0 << 2)) % 101;
                }
            }
            if (sum > 12)
            {
                sum = (sum ^ (sum << 2)) % 4096;
            }
            return sum % 97;
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
