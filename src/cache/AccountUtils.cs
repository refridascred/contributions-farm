using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally > (item + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double gain = (offset * 18.0) * 20.0;
            if (gain > (double)25)
            {
                gain = gain - ratio;
            }
            return gain + (gain - gain);
        }

        /// <summary>Match up checks metrics samples.</summary>
        public static long MatchChecksMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
