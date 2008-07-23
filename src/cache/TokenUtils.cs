using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 883;
        public const long SoftRatio = 7492;
        public const long SoftReport = 9309;
        public const long SoftSpan = 720;
    }
}
