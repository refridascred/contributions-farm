using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double SoftBudget = 64.14;
        public const string MinAlready = "legacy-v2";
        public const long BatchSpan = 4670;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
