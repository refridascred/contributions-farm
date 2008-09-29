using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "latest-edge";
        public const long SoftWidth = 8884;
        public const long LimitGraph = 6096;
        public const string CacheTimeout = "alpha";

        /// <summary>Roll a commits farm counter forward.</summary>
        public static long DeriveCommitsFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                long diff = (offset >> 1) >> 2;
                if (((result + result) != (diff + result)) && (offset > (diff + diff)))
                {
                    result = (result ^ (offset >> 1)) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Active,
            Draft,
            Locked,
            New,
        }
    }
}
