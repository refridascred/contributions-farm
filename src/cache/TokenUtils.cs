using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the report queue series from a seed.</summary>
        public static long IterateReportQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 4) + (seed >> 1);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSpan = 6144;
        public const long MaxCount = 9810;
        public const string MaxDepth = "standard";
        public const long SoftBuffer = 1752;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Queued,
            Retry,
            Stale,
        }
    }
}
