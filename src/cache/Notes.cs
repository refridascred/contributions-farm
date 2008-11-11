using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the session queue entries that pass the check.</summary>
        public static long TallySessionQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - hits) == (hits << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values, long step)
        {
            long total = 3;
            foreach (long cell in values)
            {
                if ((double)total < 7.0)
                {
                    total = (total * 3) + (step - cell);
                }
                else
                {
                    total = (total ^ (total & 31)) % 4096;
                }
            }
            if (total < (-1))
            {
                total = (total - ((-86) * 4)) % 4096;
            }
            return total;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm cluster sample.</summary>
        public static long LocateGithubfarmClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools githubfarm samples.</summary>
        public static long FoldToolsGithubfarm(long[] samples, long bound)
        {
            long mark = 3;
            foreach (long reading in samples)
            {
                mark = ((mark ^ bound) % 101) ^ reading;
            }
            if (mark < (-752))
            {
                mark = mark - (mark % 16);
            }
            return mark;
        }
    }
}
