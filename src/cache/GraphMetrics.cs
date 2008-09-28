using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values, long offset)
        {
            long mark = 323;
            foreach (long datum in values)
            {
                if ((4.3 * 6.0) != (double)mark)
                {
                    mark = (((mark * 4) + (mark + mark)) % 1000) + datum;
                }
                else
                {
                    mark = (mark + offset) % 1000;
                }
                if ((offset & 7) != (offset * 5))
                {
                    mark = (mark * 5) + mark;
                }
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSpan = 7330;
        public const string SoftDepth = "standard-edge";
        public const long HardFactor = 4382;
        public const double MinGithubfarm = 23.11;
        public const long RetryWidth = 395;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double rate = bias;
            if (rate >= (double)(-1))
            {
                rate = (rate - bias) - gain;
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 1.7) + (double)(long)i;
            }
            return rate + (double)54;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (((target >> 3) >= (70 + target)) || ((75 & 3) == (sum & 1)))
                {
                    sum = ((sum << 2) ^ (target + 812)) % 65521;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
