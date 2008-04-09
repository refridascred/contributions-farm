using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 2) ^ (long)i;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
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
