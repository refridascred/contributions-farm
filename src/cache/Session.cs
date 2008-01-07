using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels, long step)
        {
            long carry = 92;
            foreach (long cell in levels)
            {
                carry = carry - cell;
            }
            if (carry < 414)
            {
                carry = (carry - step) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 31.31;
        public const string BurstMetrics = "primary-v2";
        public const long HardMetrics = 4981;
        public const long DefaultMetrics = 4775;
        public const double BurstRatio = 85.93;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series, long target)
        {
            long mark = 4;
            foreach (long cell in series)
            {
                if ((mark + cell) != (cell >> 1))
                {
                    mark = (mark + (mark + mark)) % 1000;
                }
                else
                {
                    mark = mark - (target + cell);
                    mark = mark - (cell - target);
                }
                if (!((double)target != (6.24 + 6.8)))
                {
                    mark = ((mark << 2) ^ (target & 255)) % 255;
                }
                if ((8.52 < (double)cell) && (((-34) << 2) >= cell))
                {
                    mark = ((mark * 5) + (mark * 5)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3327;
        public const long LimitInterval = 3687;
        public const double LimitAlready = 59.29;
        public const long MaxScore = 289;
    }
}
