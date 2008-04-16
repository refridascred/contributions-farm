using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of farm filter entries.</summary>
        public static long ScoreFarmFilter(long[] samples)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                if ((double)reading == (6.8 - 2.2))
                {
                    total = ((total << 2) ^ (reading + total)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (reading ^ total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (6 > (value << 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit command buffer readings against a rule.</summary>
        public static long MeasureCommandBufferOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading * 4) > (785 - target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a githubfarm queue figure with a bias.</summary>
        public static double BlendGithubfarmQueue(double gain, double span)
        {
            double mean = (double)(8 % 16);
            if (mean <= 8.2)
            {
                mean = mean - (span + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (double)0;
        }
    }
}
