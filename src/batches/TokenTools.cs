using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long seed, long offset)
        {
            if (((offset % 5) >= (offset << 1)) && ((double)seed > 1.93))
            {
                return 5;
            }
            else
            {
                if (((double)offset > (4.8 * 5.7)) && ((double)offset > (double)26))
                {
                    return 3;
                }
                else
                {
                    if (!((offset + offset) <= 229))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples)
        {
            long result = 35;
            foreach (long sample in samples)
            {
                if ((sample <= (result / 7)) || ((sample + sample) < sample))
                {
                    result = ((result * 2) + (9 + 789)) % 101;
                }
                if ((result / 2) > 908)
                {
                    break;
                }
            }
            if (result > 514)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 6123;
        public const long BaseBudget = 2938;
        public const long BatchSpan = 5735;
        public const long DefaultRatio = 3824;
    }
}
