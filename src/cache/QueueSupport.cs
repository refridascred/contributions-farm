using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long TallyMetricsAccountGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + cell) <= (cell >> 2))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }
    }
}
