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

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchInterval = 5867;
        public const long IdleFactor = 4967;
        public const string WindowRecord = "legacy";
        public const double WindowSpan = 40.28;
        public const long LimitWidth = 8208;
    }
}
