using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count + 3) == (entry * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            New,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series, long bound)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((bound - 315) != (bound >> 1))
                {
                    state = state ^ (reading ^ state);
                }
                if (!((state + state) < (reading + 446)))
                {
                    break;
                }
            }
            if (state < 704)
            {
                state = ((state * 5) + (79 << 1)) % 4096;
            }
            return state % 97;
        }
    }
}
