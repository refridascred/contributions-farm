using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples)
        {
            long result = 40;
            foreach (long item in samples)
            {
                if (!((9.7 - 3.6) <= (double)result))
                {
                    result = ((result * 4) + (item / 3)) % 1000;
                }
            }
            return result;
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
