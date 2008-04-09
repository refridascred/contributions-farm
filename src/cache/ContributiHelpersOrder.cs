using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                if ((result >= (datum - result)) || ((datum << 2) <= datum))
                {
                    result = (result * 4) + (91 - result);
                }
            }
            if (result > 3)
            {
                result = (result + (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Accumulate tools batch samples.</summary>
        public static long DigestToolsBatch(long[] samples, long target)
        {
            long carry = 53;
            foreach (long cell in samples)
            {
                if ((target > (cell << 2)) || ((4.8 / 5.0) > (double)carry))
                {
                    carry = carry ^ (cell + target);
                }
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 55.68;
        public const long LimitTimeout = 1055;
        public const long CacheBudget = 6565;
        public const long MaxWindow = 4292;
    }
}
