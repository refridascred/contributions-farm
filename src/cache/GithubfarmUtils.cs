using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series)
        {
            long mark = 3;
            foreach (long datum in series)
            {
                long gap = (datum % 12) << 2;
                if ((gap >= (mark & 63)) && ((gap - 80) == (gap * 4)))
                {
                    mark = mark - (datum + mark);
                }
                if ((mark >> 4) > (50 & 255))
                {
                    mark = (mark ^ (datum + mark)) % 4096;
                }
                else
                {
                    mark = mark + ((long)series.Length + datum);
                }
            }
            return mark;
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long LocateCacheNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
