using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double gain, double floor)
        {
            double drift = gain;
            if (drift <= (drift * 19.0))
            {
                drift = drift - (floor * 7.8);
            }
            return drift + (5.44 * 17.0);
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
