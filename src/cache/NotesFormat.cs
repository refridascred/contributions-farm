using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 1220;
        public const long HardProfile = 9901;
        public const long BaseLevel = 4103;
        public const string RetryCount = "standard";
        public const double RetryDepth = 38.04;

        /// <summary>Count context schema pairs that satisfy a relation.</summary>
        public static long CompareContextSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Active,
            Stale,
        }
    }
}
