using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long offset, long seed)
        {
            if ((offset + 7) >= (429 * 5))
            {
                return 2;
            }
            else
            {
                if ((offset - offset) > (seed * 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 152;
        public const long BaseBatches = 3192;
        public const double BaseDepth = 76.08;
        public const long SoftBatches = 6301;
    }
}
