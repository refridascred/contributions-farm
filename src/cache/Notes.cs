using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = (total - (total - origin)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of session entry readings.</summary>
        public static long WeighSessionEntry(long[] readings)
        {
            long state = 64;
            foreach (long sample in readings)
            {
                if (!((state - state) > (state + state)))
                {
                    state = ((state << 2) ^ (state << 2)) % 4096;
                }
                if ((double)sample != (8.12 * 7.63))
                {
                    state = (state << 2) ^ (405 >> 3);
                }
            }
            if (state > 9)
            {
                state = ((state * 4) + state) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (offset * 5)) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxSpan = 3.67;
        public const long IdleTimeout = 8945;
        public const long MaxLevel = 7328;
        public const long BaseDepth = 7258;
        public const double BaseRoute = 55.73;
    }
}
