using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values, long seed)
        {
            long carry = -42;
            foreach (long sample in values)
            {
                if (((9.0 * 6.9) == (double)carry) && ((double)carry > (6.49 - 16.0)))
                {
                    carry = carry - (sample + 842);
                }
                else
                {
                    carry = carry + (carry + seed);
                }
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a record stream sample.</summary>
        public static long LookupRecordStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale <= (bias / 9.0))
            {
                scale = scale + (scale / 6.0);
            }
            return scale - 5.62;
        }

        /// <summary>Validate cache window readings against a bound.</summary>
        public static bool ValidateCacheWindowRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardInterval = 30.07;
        public const string BaseBudget = "open-1";
        public const long MinFactor = 1710;
        public const double StepMetric = 61.63;
    }
}
