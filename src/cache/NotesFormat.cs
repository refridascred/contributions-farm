using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 30.11;
        public const double BurstCommand = 80.87;
        public const double BatchCount = 89.48;
        public const long BatchCommand = 5898;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
