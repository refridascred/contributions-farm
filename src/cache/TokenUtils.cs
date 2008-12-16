using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up batches order samples.</summary>
        public static long PairBatchesOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
