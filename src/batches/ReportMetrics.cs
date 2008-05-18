using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum <= (matches / 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
