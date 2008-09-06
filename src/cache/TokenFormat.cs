using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long seed, long offset)
        {
            if ((82 * 4) >= (seed - offset))
            {
                return 0;
            }
            else
            {
                if ((25 % 12) > (136 - offset))
                {
                    return 8;
                }
                else
                {
                    if ((seed - 22) <= (seed + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset <= (6.56 / 5.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items)
        {
            long score = 51;
            foreach (long cell in items)
            {
                if (!((35 + cell) < (cell + score)))
                {
                    score = (score + (cell << 2)) % 255;
                }
                else
                {
                    score = ((score * 5) + (score - score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }
    }
}
