using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long target)
        {
            long mark = 1;
            foreach (long item in series)
            {
                mark = (mark - (7 >> 4)) % 1000;
                if (((item + mark) == (mark + mark)) && (item <= (mark / 7)))
                {
                    mark = ((mark * 3) + (target >> 4)) % 97;
                }
                else
                {
                    mark = (mark - (item - 7)) % 4096;
                }
                if (item <= target)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double mean = offset;
            if (mean >= (offset + 9.2))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (4.2 * 6.2);
            }
            return mean + mean;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Active,
            Queued,
        }
    }
}
