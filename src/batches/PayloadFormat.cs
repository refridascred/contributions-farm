using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Pending,
            New,
            Ready,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinRatio = 9519;
        public const long BatchWindow = 3984;
        public const double CacheFactor = 10.61;
        public const double MaxWindow = 70.71;
    }
}
