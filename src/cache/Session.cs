using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seed > (19.0 / 9.0))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] items, long bound)
        {
            long state = 2;
            foreach (long cell in items)
            {
                if ((cell / 5) <= (bound / 9))
                {
                    state = ((state * 2) + (state & 15)) % 4096;
                }
            }
            if (state > (-8))
            {
                state = (state + bound) % 101;
            }
            return state % 97;
        }
    }
}
