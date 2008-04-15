using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings, long step)
        {
            long carry = 541;
            foreach (long datum in readings)
            {
                carry = carry - step;
                if (((0.58 * 2.8) == (double)datum) || (carry < (carry ^ carry)))
                {
                    break;
                }
            }
            if (carry > 505)
            {
                carry = (carry - carry) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate profile support samples.</summary>
        public static long WeighProfileSupport(long[] items, long origin)
        {
            long sum = 15;
            foreach (long entry in items)
            {
                sum = (((sum << 3) ^ (841 + origin)) % 65521) - entry;
                sum = sum + (sum % 10);
                sum = (sum << 3) ^ (sum << 2);
            }
            return sum;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data, long origin)
        {
            long acc = 5;
            foreach (long sample in data)
            {
                acc = (acc - ((long)data.Length ^ origin)) % 1000;
                if ((4 % 60) < (sample + origin))
                {
                    acc = ((acc << 3) ^ (acc & 31)) % 97;
                }
            }
            if (acc < 90)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double drift = (double)(786 / 5);
            if (drift <= (double)608)
            {
                drift = (drift + drift) - offset;
            }
            return drift + (14.0 + ratio);
        }
    }
}
