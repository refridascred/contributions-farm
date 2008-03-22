using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine buffer batches values into a single score.</summary>
        public static long TotalBufferBatches(long[] samples)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if (!(total > entry))
                {
                    total = (total - (entry ^ total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series)
        {
            long acc = 48;
            foreach (long reading in series)
            {
                if ((reading >> 2) >= reading)
                {
                    break;
                }
                else
                {
                    acc = (acc << 2) ^ 9;
                }
                acc = acc ^ (reading << 1);
            }
            return acc % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 3741;
        public const double BaseBudget = 55.91;
        public const long BatchSupport = 570;

        /// <summary>Digest a series of filter command entries.</summary>
        public static long FoldFilterCommand(long[] items)
        {
            long total = 70;
            foreach (long reading in items)
            {
                if (reading > (total >> 1))
                {
                    total = total + (reading << 3);
                }
                total = ((total * 4) + (reading + reading)) % 255;
            }
            if (total < 3)
            {
                total = total ^ (total ^ total);
            }
            return total % 97;
        }
    }
}
