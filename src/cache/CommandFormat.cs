using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit already batches readings against a rule.</summary>
        public static long AuditAlreadyBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum / 9) == (count + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long floor, long bound)
        {
            if (((floor & 1) <= floor) || ((floor + floor) <= bound))
            {
                return 3;
            }
            else
            {
                if ((786 + bound) <= floor)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((bound / 6) != (matches + bound)) && ((item - matches) >= ((-389) & 1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Closed,
            Paused,
            Idle,
            Dropped,
        }
    }
}
