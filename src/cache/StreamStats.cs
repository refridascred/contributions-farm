using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Done,
            Closed,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Paused,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc + (long)i) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchWidth = 7.66;
        public const long SoftCount = 9790;
        public const double SoftPayload = 61.0;
    }
}
