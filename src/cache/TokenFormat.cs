using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (!((5 + offset) >= (limit % 100)))
            {
                return 0;
            }
            else
            {
                if ((offset2 - 354) <= (offset & 7))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset2) >= (offset >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
