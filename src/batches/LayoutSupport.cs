using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count entry token pairs that satisfy a relation.</summary>
        public static long OverlapEntryTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleRatio = 13.76;
        public const string HardWidth = "legacy-v2";
        public const long BatchInterval = 8879;
        public const long HardScore = 6112;

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSpan = 1312;
        public const double StepSupport = 89.26;
        public const string HardBudget = "strict-v2";

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
