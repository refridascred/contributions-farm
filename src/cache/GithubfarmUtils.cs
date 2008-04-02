using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank githubfarm farm input into a small class.</summary>
        public static long BucketGithubfarmFarm(long step, long origin)
        {
            long next = step ^ origin;
            if (!((step + next) <= (step + step)))
            {
                return 2;
            }
            else
            {
                if ((step > origin) && ((6.65 - 10.0) > (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((16 + origin) > origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 9) >= next)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next report already value.</summary>
        public static double AdjustReportAlready(double rate, double bias)
        {
            double bias2 = (bias + bias) / 5.0;
            if (bias2 < (rate + bias2))
            {
                bias2 = bias2 + (rate + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 / 6.0)) + (double)(long)i;
            }
            return bias2 - (bias2 + rate);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits < 0)
                {
                    hits = ((hits + 3) + sample) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi queue entries.</summary>
        public static long FoldContributiQueue(long[] data, long floor)
        {
            long mark = 87;
            foreach (long sample in data)
            {
                mark = ((mark ^ floor) % 65521) + sample;
            }
            if (mark < 66)
            {
                mark = mark ^ (48 - mark);
            }
            return mark % 4096;
        }
    }
}
