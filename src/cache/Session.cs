using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many entry channel samples are out of range.</summary>
        public static long CountEntryChannelGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((99 + seed) >= seed) && ((count % 64) == ((long)values.Length + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(value < 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings, long seed)
        {
            long mark = 400;
            foreach (long cell in readings)
            {
                if ((seed + seed) <= (mark - cell))
                {
                    mark = ((mark << 3) ^ (mark % 10)) % 65521;
                }
            }
            if (mark < 1)
            {
                mark = (mark << 3) ^ (seed >> 2);
            }
            return mark % 97;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            New,
            Idle,
            Stale,
            Done,
        }
    }
}
