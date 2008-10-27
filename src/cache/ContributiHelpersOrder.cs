using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target & 63) >= (113 << 2))
                {
                    anchor = (anchor ^ (anchor ^ target)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (double)matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine entry order values into a single score.</summary>
        public static long FoldEntryOrder(long[] readings)
        {
            long state = 742;
            foreach (long reading in readings)
            {
                state = ((state * 3) + state) ^ reading;
            }
            if (state < 0)
            {
                state = ((state << 2) ^ state) % 4096;
            }
            return state;
        }
    }
}
