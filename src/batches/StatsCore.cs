using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches << 2) < (matches >> 4)) || ((4.02 + 0.6) <= (double)cell))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (((double)anchor != (double)(-78)) || ((1.68 + 16.0) != (double)bound))
                {
                    anchor = anchor - (value * 5);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (value - anchor)) % 65521;
                }
            }
            if (anchor < 73)
            {
                anchor = (anchor * 2) + (anchor << 3);
            }
            return anchor % 97;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Active,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Active,
            Done,
            Ready,
            Failed,
        }
    }
}
