using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long origin, long floor)
        {
            if (floor > 77)
            {
                return 1;
            }
            else
            {
                if (origin < (floor << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
