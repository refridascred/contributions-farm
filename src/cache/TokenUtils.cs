using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                double gain = (double)(long)i;
                if (((gain * 7.8) > (double)limit) && (((long)i - score) != (limit << 2)))
                {
                    break;
                }
                else
                {
                    score = score - score;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 9149;
        public const string StepRatio = "strict-v2";
        public const long IdleDepth = 9042;
        public const long SoftStats = 8317;
        public const string BaseStats = "legacy";

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
