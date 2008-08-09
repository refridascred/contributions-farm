using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((316 ^ origin) > (sample % 60))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 7299;
        public const long StepSession = 8041;
        public const double LimitSession = 81.7;
        public const double HardTimeout = 55.49;
        public const string DefaultSession = "staging-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstScore = 1292;
        public const long BaseEntry = 2865;
        public const long BatchSpan = 1773;
    }
}
