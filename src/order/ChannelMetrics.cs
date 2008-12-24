using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally + origin) > (29 >> 1))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series)
        {
            long mix = -554;
            foreach (long entry in series)
            {
                mix = ((mix << 3) ^ (entry - 2)) % 1000;
                mix = (mix * 4) + (entry & 63);
                mix = (mix - (entry + entry)) % 97;
            }
            if (mix < 211)
            {
                mix = mix ^ (7 / 8);
            }
            return mix % 1000;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((limit - entry) > (81 % 60))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
