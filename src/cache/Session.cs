using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result - ((long)i / 6)) - (long)i2;
                }
                result = (result ^ (long)i) % 101;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((double)hits > (14.0 * 2.68)) || ((cell - hits) != (hits - step)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Count the commits tools entries that pass the check.</summary>
        public static long AuditCommitsToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (5.94 < (double)value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
