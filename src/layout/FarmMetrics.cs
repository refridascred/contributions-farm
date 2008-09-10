using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Measure how many githubfarm queue samples are out of range.</summary>
        public static long TallyGithubfarmQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches % 97) <= (entry % 97))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] values, long seed)
        {
            long anchor = 7;
            foreach (long item in values)
            {
                if ((0.7 - 8.0) < (double)item)
                {
                    anchor = ((anchor ^ (item - anchor)) % 65521) + seed;
                }
                else
                {
                    anchor = anchor ^ (anchor << 2);
                }
            }
            return anchor;
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long TallyContributiRecordGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((limit <= (hits ^ (long)data.Length)) && ((hits - limit) > (datum * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
