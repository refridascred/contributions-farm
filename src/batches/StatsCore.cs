using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items)
        {
            long mark = 57;
            foreach (long entry in items)
            {
                mark = (mark * 3) + ((-66) + entry);
            }
            if (mark < (-10))
            {
                mark = mark - ((long)items.Length + mark);
            }
            return mark;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor * 5) + seed;
                anchor = (anchor ^ (seed % 10)) % 97;
                if ((seed - 980) < (524 ^ 200))
                {
                    anchor = ((anchor << 3) ^ (anchor & 3)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Measure how many channel githubfarm samples are out of range.</summary>
        public static long MeasureChannelGithubfarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value < 8.6)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + count) == (count % 5))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
