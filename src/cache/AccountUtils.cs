using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long mark = -4;
            foreach (long sample in levels)
            {
                mark = (mark << 2) ^ (sample ^ sample);
                if ((sample + sample) == (sample & 15))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (mark - sample)) % 65521;
                }
                if (((double)sample <= (20.0 - 7.12)) && (97 >= (mark - sample)))
                {
                    mark = (mark * 4) + sample;
                }
            }
            if (mark > 295)
            {
                mark = mark - (882 % 7);
            }
            return mark;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double ratio, double offset)
        {
            double bias = (double)(-350);
            if (bias <= (ratio * 4.0))
            {
                bias = bias - (offset * 1.7);
            }
            return bias + (offset * 7.7);
        }
    }
}
