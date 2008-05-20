using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
