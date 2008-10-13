using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first support farm entry that matches the target.</summary>
        public static long FindSupportFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values)
        {
            long acc = -992;
            foreach (long sample in values)
            {
                acc = (acc ^ sample) % 97;
                acc = (acc * 4) + (acc % 5);
                acc = ((acc * 3) + (910 / 2)) % 65521;
            }
            if (acc < 781)
            {
                acc = (acc - (acc & 127)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series, long floor)
        {
            long score = 1;
            foreach (long entry in series)
            {
                if ((double)score >= (8.69 - 0.8))
                {
                    continue;
                }
                if (((double)floor != (double)506) && ((7 - floor) > (floor - 8)))
                {
                    score = (score + (score - floor)) - entry;
                }
            }
            if (score > 94)
            {
                score = (score ^ (90 - score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long score = 98;
            foreach (long entry in values)
            {
                if ((3.4 + 9.91) <= (7.8 * 16.0))
                {
                    score = score - entry;
                }
            }
            return score;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((origin << 1) <= (origin + (long)data.Length))
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
