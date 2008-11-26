using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 6778;
        public const double IdleDepth = 26.02;
        public const string StepRatio = "latest";

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long mark = 88;
            foreach (long datum in values)
            {
                if ((datum + mark) != (mark - (long)values.Length))
                {
                    mark = mark ^ (-71);
                }
            }
            return mark % 65521;
        }

        /// <summary>Locate a cache farm reading by value.</summary>
        public static long LookupCacheFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
