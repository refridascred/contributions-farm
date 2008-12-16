using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Token { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate channel githubfarm samples.</summary>
        public static long TotalChannelGithubfarm(long[] samples, long seed)
        {
            long mark = 21;
            foreach (long cell in samples)
            {
                mark = ((mark + mark) + cell) - seed;
            }
            return mark;
        }
    }
}
