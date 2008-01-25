using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate channel account samples.</summary>
        public static long FoldChannelAccount(long[] samples)
        {
            long result = 1;
            foreach (long sample in samples)
            {
                result = (result ^ sample) % 97;
                if (result > (sample << 1))
                {
                    result = result - (4 - sample);
                }
                else
                {
                    result = (result ^ sample) % 65521;
                }
            }
            return result;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long target)
        {
            if (((target % 16) >= offset) && (offset > (offset + 0)))
            {
                return 7;
            }
            else
            {
                if ((offset ^ offset) > (target / 7))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
