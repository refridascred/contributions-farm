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

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + 966;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
