using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a context notes pair into a bucket.</summary>
        public static long SortContextNotes(long limit, long target)
        {
            long step = limit + target;
            if ((target & 7) < 535)
            {
                return 3;
            }
            else
            {
                if ((0.34 * 6.0) == (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target ^ step) <= (target - target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
