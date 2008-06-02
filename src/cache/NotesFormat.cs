using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long IterateClusterFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((bound - bound) != ((long)i >> 1)) && ((20 + bound) <= 4))
                {
                    state = (state << 2) ^ (long)i;
                }
                state = (state - (bound * 3)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((double)acc >= (9.0 / 4.0))
                {
                    acc = (acc ^ (acc - seed)) % 1000;
                }
                if (((long)i << 3) < 850)
                {
                    acc = (acc + acc) % 1000;
                }
                acc = ((acc * 4) + acc) % 1000;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine batches route values into a single score.</summary>
        public static long CombineBatchesRoute(long[] values, long limit)
        {
            long anchor = 62;
            foreach (long item in values)
            {
                anchor = ((anchor * 3) + (limit << 1)) % 1000;
                if ((anchor - anchor) >= (item * 3))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
