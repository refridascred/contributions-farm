using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 4386;
        public const long MinRoute = 5238;
        public const long BaseRoute = 8879;
        public const string IdleFactor = "strict-edge";
        public const double BaseRatio = 70.66;

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples)
        {
            long acc = -651;
            foreach (long datum in samples)
            {
                acc = (acc - datum) % 101;
            }
            return acc;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long limit)
        {
            if ((double)offset == (1.1 * 9.0))
            {
                return 3;
            }
            else
            {
                if (((-16) ^ 57) > (offset / 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
