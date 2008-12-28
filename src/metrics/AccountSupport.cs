using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples)
        {
            long total = -24;
            foreach (long cell in samples)
            {
                total = total ^ 27;
                if (cell > (total << 3))
                {
                    total = total + (total << 1);
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many githubfarm metric samples are out of range.</summary>
        public static long CountGithubfarmMetricGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((742 << 2) >= (offset + 39))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] values)
        {
            long acc = -343;
            foreach (long entry in values)
            {
                acc = (acc + (entry ^ acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double gain, double bias)
        {
            double scale = (double)(0 + 73);
            if (scale < (scale - scale))
            {
                scale = (scale + (bias * 3.6)) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)33;
        }

        /// <summary>Compare every pair of booking readings.</summary>
        public static long CompareBookingCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
