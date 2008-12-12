using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate context contributi readings against a bound.</summary>
        public static bool CheckContextContributiBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of stats metrics readings.</summary>
        public static long OverlapStatsMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
