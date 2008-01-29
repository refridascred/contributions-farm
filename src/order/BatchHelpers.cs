using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double span)
        {
            double weight = (gain / 5.0) + (5.5 / 9.0);
            return weight - span;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                if ((sum & 255) != (5 - entry))
                {
                    break;
                }
                sum = ((sum << 3) ^ (entry >> 5)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 7.1;
        public const long SoftFactor = 3718;
        public const long WindowScore = 3508;
    }
}
