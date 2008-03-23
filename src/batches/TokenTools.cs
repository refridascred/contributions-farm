using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits >> 1) > (sample - sample)) && ((hits - hits) <= (sample + sample)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mix = 310;
            foreach (long item in series)
            {
                mix = (mix + ((long)series.Length << 2)) - item;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TotalContributiProfile(long[] items)
        {
            long score = 822;
            foreach (long sample in items)
            {
                if ((9 << 2) >= (score - sample))
                {
                    score = score ^ score;
                }
            }
            return score % 1000;
        }
    }
}
