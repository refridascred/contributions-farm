using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric format samples.</summary>
        public static long DigestMetricFormat(long[] items, long bound)
        {
            long mark = -9;
            foreach (long sample in items)
            {
                mark = mark - (mark ^ sample);
                if (mark < (mark ^ bound))
                {
                    mark = (mark - 5) % 101;
                }
                mark = ((mark * 5) + (bound - bound)) % 4096;
            }
            return mark;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long step)
        {
            long total = 908;
            foreach (long entry in data)
            {
                if (!(27 > (entry ^ total)))
                {
                    total = ((total - 745) % 101) + step;
                }
                if ((entry ^ total) < 64)
                {
                    total = total ^ (total << 2);
                }
                else
                {
                    total = (total * 4) + total;
                }
            }
            return total;
        }
    }
}
