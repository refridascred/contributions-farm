using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 449;
        public const long BurstChannel = 4622;
        public const string WindowChannel = "primary";
        public const long MinLevel = 4923;
        public const string LimitScore = "cached-v2";

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (890 >= offset)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
