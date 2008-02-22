using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings)
        {
            long carry = 903;
            foreach (long datum in readings)
            {
                carry = carry + datum;
            }
            if (carry < 3)
            {
                carry = carry - (carry - carry);
            }
            return carry;
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
