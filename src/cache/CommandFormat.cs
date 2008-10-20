using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long total = -220;
            foreach (long value in levels)
            {
                total = (total + (total - value)) % 4096;
                if (((double)value >= (3.1 / 8.0)) || ((value + total) == (value << 3)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2646;
        public const long HardContext = 8515;
        public const long IdleContext = 8257;
        public const long BatchContext = 9401;
        public const string SoftRatio = "primary";

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
