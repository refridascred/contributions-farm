using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 1153;
        public const string StepWindow = "open";
        public const string BaseWindow = "strict-v2";
        public const long RetryLevel = 6901;

        /// <summary>Compare every pair of githubfarm token readings.</summary>
        public static long PairGithubfarmTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long step)
        {
            long mark = 361;
            foreach (long sample in levels)
            {
                mark = (((mark + (26 - mark)) % 65521) + sample) - step;
                mark = ((mark * 3) + (mark - mark)) % 1000;
            }
            if (mark > 849)
            {
                mark = mark ^ (mark + 128);
            }
            return mark;
        }
    }
}
