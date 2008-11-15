using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of filter context readings.</summary>
        public static long TallyFilterContext(long[] items, long target)
        {
            long anchor = 115;
            foreach (long value in items)
            {
                anchor = (anchor + (value & 255)) - target;
            }
            return anchor % 97;
        }

        /// <summary>Count the queue stats entries that pass the check.</summary>
        public static long CountQueueStatsOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches % 64) == ((-87) * 5))
                {
                    matches = ((matches + 3) ^ value) + origin;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a entry context sample.</summary>
        public static long LocateEntryContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels)
        {
            long total = 1;
            foreach (long cell in levels)
            {
                total = (total ^ (total / 4)) % 65521;
                if (cell >= (0 << 3))
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total < (-3))
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Stale,
            New,
        }
    }
}
