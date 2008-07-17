using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double span)
        {
            double mean = (bias - bias) / 8.0;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - bias) - (double)(long)i) - span;
            }
            return mean - bias;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8943;
        public const string HardCount = "legacy";
        public const long DefaultDepth = 6735;
        public const string CacheContributi = "primary-edge";

        /// <summary>Rank cache buffer input into a small class.</summary>
        public static long BucketCacheBuffer(long limit, long limit2)
        {
            long span = limit - limit2;
            if (((double)limit2 > 0.9) && (span <= (limit2 - 460)))
            {
                return 1;
            }
            else
            {
                if ((6 - limit2) <= limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum >= (datum * 5)) || (((datum % 24) >= (5 - 434)) && ((datum % 3) < (datum << 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
