using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Count batch session pairs that satisfy a relation.</summary>
        public static long CompareBatchSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel window entries.</summary>
        public static long FoldChannelWindow(long[] readings)
        {
            long score = 10;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ (sample - (long)readings.Length);
                if ((double)score == (double)sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many filter order samples are out of range.</summary>
        public static long TallyFilterOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally % 64) >= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
