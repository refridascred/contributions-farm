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

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series, long step)
        {
            long sum = 203;
            foreach (long value in series)
            {
                if ((double)step < 2.19)
                {
                    sum = ((sum * 3) + (step + value)) % 1000;
                }
                else
                {
                    sum = sum - (step + sum);
                }
            }
            if (sum < 734)
            {
                sum = (sum * 3) + step;
            }
            return sum;
        }

        /// <summary>Match up entry githubfarm samples.</summary>
        public static long OverlapEntryGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
