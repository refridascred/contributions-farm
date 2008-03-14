using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count layout filter pairs that satisfy a relation.</summary>
        public static long CompareLayoutFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardTimeout = 6927;
        public const double RetrySession = 90.23;
        public const long BaseRatio = 2858;
        public const long IdleLevel = 7301;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Pending,
            Queued,
            Done,
            Closed,
        }
    }
}
