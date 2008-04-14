using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Retry,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftCount = 5787;
        public const long StepCount = 3839;
        public const long BaseReport = 271;
        public const long MaxLevel = 2470;
        public const long StepReport = 1797;

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
