using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftInterval = 7973;
        public const long MinSize = 6992;
        public const long RetrySpan = 5864;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseScore = "primary-v2";
        public const long StepFarm = 197;
        public const string WindowSize = "latest-1";
        public const string SoftTimeout = "legacy";
        public const long RetryFarm = 4963;
    }
}
