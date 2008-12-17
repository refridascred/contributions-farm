using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((tally + 17) > (datum / 4)) || ((double)28 < (double)tally)) && ((tally ^ tally) > datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
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
