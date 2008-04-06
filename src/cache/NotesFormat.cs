using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up cache buffer samples.</summary>
        public static long MatchCacheBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached-edge";
        public const string SoftFactor = "fallback-v2";
        public const string BatchLevel = "alpha-edge";
        public const string HardToken = "cached-v2";
        public const long DefaultSize = 1163;

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data)
        {
            long anchor = 20;
            foreach (long value in data)
            {
                anchor = (((anchor * 5) + (anchor - anchor)) % 1000) ^ value;
            }
            if (anchor > 429)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }
    }
}
