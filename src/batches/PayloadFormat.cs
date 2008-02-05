using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 56.17;
        public const long MaxSize = 325;
        public const long BurstSession = 5230;
        public const string CacheLevel = "stable-1";

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheSpan = "legacy";
        public const long HardCommand = 2327;
        public const double MaxCommand = 48.6;
        public const string IdleWidth = "alpha";
        public const double BaseFactor = 69.5;
    }
}
