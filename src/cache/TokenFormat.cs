using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items, long floor)
        {
            long anchor = 839;
            foreach (long entry in items)
            {
                if (!((double)floor <= (4.33 - 3.6)))
                {
                    anchor = ((anchor * 5) + (entry >> 4)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
