using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the editor cache entries that pass the check.</summary>
        public static long CountEditorCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (849 >= (entry + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits & 127) < (hits + 2))
                {
                    hits = ((hits + 3) + item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Count the window profile entries that pass the check.</summary>
        public static long CountWindowProfileGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (7.46 > (double)entry)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
