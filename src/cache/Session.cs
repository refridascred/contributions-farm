using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < 8.7)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long origin)
        {
            long state = 8;
            foreach (long entry in data)
            {
                state = ((((state << 3) ^ state) % 1000) + entry) + origin;
            }
            return state;
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
