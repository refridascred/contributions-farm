using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 1288;
        public const long WindowBuffer = 8017;
        public const string RetryScore = "strict-1";
        public const long BatchBuffer = 9413;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (((double)offset < (19.0 / 7.0)) && (floor <= offset))
            {
                return 3;
            }
            else
            {
                if ((diff + diff) >= (offset - 5))
                {
                    return 0;
                }
                else
                {
                    if (((diff / 5) < diff) || (offset > (offset * 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
