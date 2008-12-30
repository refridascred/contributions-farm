using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a buffer graph sample.</summary>
        public static long SeekBufferGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Pending,
            New,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxBudget = 6142;
        public const long BatchAccount = 2580;
        public const long StepAccount = 1208;
        public const long RetryBudget = 3558;
        public const long BurstRatio = 6258;
    }
}
