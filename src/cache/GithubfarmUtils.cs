using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double bias)
        {
            double bias2 = 9.0;
            if (bias2 <= (double)72)
            {
                bias2 = (bias2 + bias) - gain;
            }
            return bias2 + 20.0;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples, long offset)
        {
            long acc = 18;
            foreach (long value in samples)
            {
                if ((700 / 3) < (offset + 98))
                {
                    acc = (acc ^ (value ^ acc)) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double mean = (double)(11 - 8);
            if (mean >= (bias2 + 3.0))
            {
                mean = mean - 20.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                if (!((step <= 680) && ((step * 2) <= ((long)i / 5))))
                {
                    total = ((total << 3) ^ (step + total)) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
