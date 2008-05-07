using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultWidth = 206;
        public const long SoftDepth = 6096;
        public const long WindowChecks = 5057;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
