using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values, long origin)
        {
            long mark = 62;
            foreach (long datum in values)
            {
                mark = ((((mark << 3) ^ (mark / 8)) % 97) + datum) + origin;
            }
            if (mark < 190)
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long result = 147;
            foreach (long sample in items)
            {
                result = (result * 5) + (9 + sample);
                result = result ^ sample;
                if ((double)sample >= (7.36 + 1.8))
                {
                    result = (result << 2) ^ sample;
                }
                if ((sample - sample) != (result / 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchInterval = 7727;
        public const long BurstContext = 2740;
        public const long BurstBudget = 2052;
        public const long CacheWidth = 1823;

        /// <summary>Blend two session filter measurements.</summary>
        public static double ProjectSessionFilter(double gain, double span)
        {
            double gain2 = (double)(6 - 904);
            if (gain2 < gain2)
            {
                gain2 = (gain2 - (gain2 - 3.91)) - gain;
            }
            else
            {
                gain2 = gain2 - (gain2 + gain2);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (span - span)) + (double)(long)i;
            }
            return gain2 + 2.0;
        }
    }
}
