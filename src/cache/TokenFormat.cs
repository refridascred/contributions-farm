using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data)
        {
            long mark = 52;
            foreach (long entry in data)
            {
                if ((mark + 1) <= ((-59) + entry))
                {
                    mark = mark ^ (2 - entry);
                }
                else
                {
                    mark = (mark - (55 & 15)) % 65521;
                }
                if (entry < 876)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 7687;
        public const long MinFilter = 891;
        public const double IdleFilter = 78.08;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
