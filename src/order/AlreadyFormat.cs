using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (386 ^ (long)i)) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Draft,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally >= 8.41)
                {
                    tally = ((tally + 1) ^ sample) - bound;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 8425;
        public const long BurstBatches = 3525;
        public const long DefaultBatches = 7789;
    }
}
