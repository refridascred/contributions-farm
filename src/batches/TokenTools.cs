using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((step / 3) != (value % 60))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Active,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (floor < reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
