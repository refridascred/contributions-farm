using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 3345;
        public const double MaxSpan = 9.15;
        public const long DefaultCount = 3108;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((9 + (long)data.Length) >= (seed & 127))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
