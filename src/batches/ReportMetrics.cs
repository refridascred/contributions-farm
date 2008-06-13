using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] values, long step)
        {
            long acc = 976;
            foreach (long value in values)
            {
                acc = ((acc + step) % 255) + value;
                if ((step ^ step) < (acc - step))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
