using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 72.2;
        public const string SoftFactor = "strict-v2";
        public const long MinRecord = 9318;
        public const long LimitSize = 3403;

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
