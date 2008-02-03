using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cache cluster entry that matches the target.</summary>
        public static long LocateCacheClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry metrics values into a single score.</summary>
        public static long ScoreEntryMetrics(long[] items)
        {
            long score = -1;
            foreach (long sample in items)
            {
                if ((sample + sample) <= (9 + 649))
                {
                    score = (score + (sample % 100)) % 255;
                }
                if ((sample << 3) > (1 - (-269)))
                {
                    score = (score - sample) % 97;
                }
                else
                {
                    score = (score ^ (59 - sample)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
