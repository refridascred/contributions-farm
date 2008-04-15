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

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Locked,
            Synced,
            Retry,
            Stale,
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

        /// <summary>Combine window checks values into a single score.</summary>
        public static long CombineWindowChecks(long[] readings)
        {
            long mark = 2;
            foreach (long reading in readings)
            {
                if (!((8.7 + 18.0) <= (double)reading))
                {
                    mark = (mark << 2) ^ (reading - reading);
                }
                else
                {
                    mark = (mark - (mark ^ reading)) % 101;
                }
                if (((2.66 - 2.2) > (2.0 - 9.0)) || (reading > ((long)readings.Length / 8)))
                {
                    mark = mark + (reading / 6);
                }
            }
            return mark % 1000;
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
