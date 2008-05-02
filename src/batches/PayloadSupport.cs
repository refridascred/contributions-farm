using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches % 100) >= (3 / 2)) || ((matches + datum) > matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSpan = 7313;
        public const long WindowCache = 5881;
        public const long RetryCache = 551;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
