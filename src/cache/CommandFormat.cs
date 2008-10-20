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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (2.38 * 9.2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
