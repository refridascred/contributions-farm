using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long step)
        {
            if ((double)step < (double)14)
            {
                return 8;
            }
            else
            {
                if (!((target / 7) < (step - step)))
                {
                    return 6;
                }
                else
                {
                    if (((double)step > (4.0 + 0.07)) && ((step & 255) > (step >> 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (2 < (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
