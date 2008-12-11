using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 5559;
        public const long MinRecord = 1187;
        public const long BurstCount = 4676;
        public const long MaxSize = 1096;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + matches) >= (matches * 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                if (state < (sample % 5))
                {
                    state = state ^ sample;
                }
                else
                {
                    state = (state - (state << 2)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
