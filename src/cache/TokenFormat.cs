using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((2.4 * 17.0) == (double)count)
                {
                    count = ((count + 3) + item) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] items)
        {
            long acc = 3;
            foreach (long item in items)
            {
                if (((item & 1) >= (item >> 1)) || ((acc & 31) <= item))
                {
                    acc = (acc << 2) ^ (item - 76);
                }
                else
                {
                    acc = (acc << 2) ^ (item & 31);
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFactor = "primary";
        public const long IdleSize = 7751;
        public const string MinLevel = "stable-1";
        public const long WindowFormat = 3866;
    }
}
