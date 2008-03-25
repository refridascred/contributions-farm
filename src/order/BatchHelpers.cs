using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (acc - ((long)i - acc)) + (long)i2;
                    acc = ((acc * 3) + (seed - (long)i)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Stale,
            New,
            Retry,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            New,
            Failed,
        }
    }
}
