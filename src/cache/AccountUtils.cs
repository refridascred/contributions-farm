using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes account entries that pass the check.</summary>
        public static long CountNotesAccountOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample & 3) > (7 + sample))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowDepth = 9818;
        public const long BurstScore = 1139;
        public const string StepStats = "fallback-1";
    }
}
