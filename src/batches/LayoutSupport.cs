using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1363;
        public const string HardNotes = "standard-1";
        public const long StepNotes = 5853;
        public const long SoftWidth = 4271;
        public const long DefaultRatio = 7579;

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 96.97;
        public const long CacheEditor = 8248;
        public const string SoftRatio = "open-v2";
        public const double HardEditor = 29.06;
        public const long DefaultDepth = 8485;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first schema command entry that matches the target.</summary>
        public static long LookupSchemaCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 2972;
        public const long LimitScore = 5072;
        public const string BurstStream = "strict-v2";
        public const string WindowLevel = "fallback-1";
        public const string LimitWidth = "stable-edge";
    }
}
