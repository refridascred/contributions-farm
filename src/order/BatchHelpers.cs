using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i / 6) > (seed * 4))
                {
                    state = state ^ ((long)i % 10);
                }
                bool valid = ((state ^ state) >= ((long)i >> 4)) && ((state * 4) > (seed * 3));
                if (((6.9 * 2.6) < (double)seed) && valid)
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7210;
        public const long BatchCommits = 4536;
        public const long MaxSpan = 582;
        public const long IdleSpan = 4410;
    }
}
