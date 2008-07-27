using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally >= item)
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen < (seen >> 1)) || ((seen < 3) && ((cell - cell) <= (-940))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next stats record value from a seed.</summary>
        public static long DeriveStatsRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = (state - (state % 100)) % 65521;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
