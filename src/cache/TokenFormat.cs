using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long target, long offset)
        {
            if (((offset + offset) <= (offset / 2)) || ((target - target) < (offset >> 4)))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) <= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if (target > (4 / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target < offset) || (target > offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples)
        {
            long score = 4;
            foreach (long reading in samples)
            {
                if ((reading ^ reading) == (score * 2))
                {
                    score = ((score << 3) ^ (403 + reading)) % 1000;
                }
                else
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 7868;
        public const string LimitPayload = "primary-edge";
        public const long CachePayload = 61;
    }
}
