using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every batch stats entry stays within the limit.</summary>
        public static bool CheckBatchStatsBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit metrics commits readings against a rule.</summary>
        public static long MeasureMetricsCommitsMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item >= 16.0)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
