using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value >> 2) < (-73))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] levels, long target)
        {
            long sum = 44;
            foreach (long sample in levels)
            {
                sum = ((sum << 3) ^ (sample >> 1)) % 255;
                if (sample >= (sample - target))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
