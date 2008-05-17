using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long score = 110;
            foreach (long item in samples)
            {
                if (!((double)item < (double)score))
                {
                    score = (score - step) % 101;
                    score = (score * 3) + (item & 31);
                }
                if (((step + score) <= step) && ((item * 3) >= (score + item)))
                {
                    score = (score ^ (item * 2)) % 101;
                }
                else
                {
                    score = score - (score + 49);
                }
            }
            return score;
        }

        /// <summary>Accumulate githubfarm support samples.</summary>
        public static long ScoreGithubfarmSupport(long[] data, long bound)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                mix = (mix * 2) + (bound - sample);
                if (mix <= bound)
                {
                    mix = (mix << 3) ^ (mix + sample);
                }
                else
                {
                    mix = (mix ^ (61 * 5)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (floor < (floor % 10))
                {
                    count = (count + 3) + datum;
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
