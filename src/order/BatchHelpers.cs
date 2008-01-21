using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((9.7 * 16.0) == (double)hits)
                {
                    hits = ((hits + 1) ^ entry) + offset;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer layout readings against a bound.</summary>
        public static bool VerifyBufferLayoutLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
