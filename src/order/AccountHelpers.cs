using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 5586;
        public const long CacheSize = 2408;
        public const long MaxCount = 7075;
        public const long LimitBudget = 3089;
        public const long RetryChecks = 6925;

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 2) ^ (offset & 63)) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples)
        {
            long carry = 719;
            foreach (long value in samples)
            {
                carry = ((carry - (carry ^ 17)) % 4096) + value;
            }
            if (carry < 2)
            {
                carry = carry ^ (carry >> 3);
            }
            return carry % 97;
        }
    }
}
