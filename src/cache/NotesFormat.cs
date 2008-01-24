using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 9008;
        public const string SoftOrder = "primary-1";
        public const long HardScore = 2634;
        public const long MaxOrder = 6080;
    }
}
