using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item / 8) >= (count - item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data)
        {
            long total = 4;
            foreach (long datum in data)
            {
                if ((datum >> 3) >= (total - datum))
                {
                    total = (total ^ datum) % 255;
                }
                total = ((total << 3) ^ (52 + 6)) % 4096;
            }
            return total;
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long SeekCacheNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Locked,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((-787) - 89) >= (origin >> 2))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
