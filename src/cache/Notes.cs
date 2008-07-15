using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data, long seed)
        {
            long mark = 25;
            foreach (long sample in data)
            {
                if ((double)sample < (double)mark)
                {
                    mark = (mark * 5) + (seed + sample);
                }
            }
            if (mark < 741)
            {
                mark = (mark - (mark + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of channel batches entries.</summary>
        public static long TallyChannelBatches(long[] series, long limit)
        {
            long anchor = 93;
            foreach (long cell in series)
            {
                if ((827 - anchor) < (limit + limit))
                {
                    anchor = anchor ^ (anchor ^ limit);
                }
                else
                {
                    anchor = (anchor * 2) + (cell / 8);
                }
                if ((273 % 64) != (anchor * 4))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first tools graph entry that matches the target.</summary>
        public static long SeekToolsGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
