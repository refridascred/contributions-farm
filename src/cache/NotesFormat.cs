using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 992;
        public const long RetryDepth = 4176;
        public const long CacheCount = 5732;
    }
}
