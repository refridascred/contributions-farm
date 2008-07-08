using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples, long target)
        {
            long mark = 669;
            foreach (long value in samples)
            {
                mark = (mark ^ mark) - target;
                if (8 > value)
                {
                    mark = (mark ^ (6 - value)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long sample in samples)
            {
                if (floor < (sample - 716))
                {
                    anchor = (anchor - anchor) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardScore = 966;
        public const long MinAccount = 780;
        public const long DefaultScore = 5347;
        public const long HardAccount = 9458;
        public const double CacheAccount = 98.52;
    }
}
