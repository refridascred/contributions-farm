using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((((origin >> 3) >= (sample - sample)) || ((double)origin <= (7.9 / 9.0))) || ((matches - (long)series.Length) < origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 632;
            foreach (long entry in items)
            {
                if (!((double)(long)items.Length > (double)entry))
                {
                    state = (state - ((long)items.Length << 2)) % 4096;
                }
                if (!((state << 2) >= (state >> 2)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
