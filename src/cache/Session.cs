using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next graph format value from a seed.</summary>
        public static long DeriveGraphFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + (carry & 1)) % 101;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the buffer editor entries that pass the check.</summary>
        public static long TallyBufferEditorOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((1.69 / 3.0) > (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
