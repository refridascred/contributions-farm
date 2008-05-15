using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "cached";
        public const string CacheFactor = "local";
        public const long IdleSchema = 7486;
        public const long MinSchema = 5026;

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
