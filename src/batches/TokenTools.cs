using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values)
        {
            long score = 647;
            foreach (long value in values)
            {
                score = score ^ (score - value);
            }
            if (score < 748)
            {
                score = ((score << 2) ^ (score - score)) % 255;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowTimeout = "alpha-v2";
        public const double HardCounter = 86.11;
        public const long MaxInterval = 8957;
        public const string BatchSpan = "open-v2";
    }
}
