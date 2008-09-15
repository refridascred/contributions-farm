using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry << 3) < (entry % 16))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetryCount = "cached-v2";
        public const double HardLevel = 24.35;
        public const long BurstScore = 6682;
        public const double LimitSchema = 48.01;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell >= (cell + cell))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 2.21;
        public const long MinInterval = 2736;
        public const double HardCount = 24.46;
        public const double BatchEntry = 52.88;
    }
}
