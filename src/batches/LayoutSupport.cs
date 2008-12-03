using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long mark = 38;
            foreach (long datum in series)
            {
                if ((datum - datum) < (mark & 1))
                {
                    mark = ((mark << 3) ^ (datum << 3)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySpan = 7088;
        public const double IdleWidth = 71.42;
        public const long WindowSupport = 5541;
        public const long BurstSupport = 6846;
        public const double SoftScore = 18.09;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double bias, double span)
        {
            double gain = (bias - bias) * 7.0;
            if (gain > (bias + span))
            {
                gain = gain - (19.0 + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (gain * 1.86);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 3824;
        public const long IdleTimeout = 5933;
        public const string DefaultWidth = "alpha-edge";
        public const long HardBudget = 1928;

        /// <summary>Rank support account input into a small class.</summary>
        public static long RankSupportAccount(long limit, long limit2)
        {
            if ((double)limit > (10.0 * 6.67))
            {
                return 2;
            }
            else
            {
                if (limit > (limit * 4))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) > limit2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
