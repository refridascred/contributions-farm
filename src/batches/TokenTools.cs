using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long origin)
        {
            long sum = 213;
            foreach (long cell in values)
            {
                if ((58 % 5) < origin)
                {
                    sum = (((sum * 5) + sum) % 97) ^ cell;
                }
                else
                {
                    sum = (sum - (sum + origin)) % 4096;
                }
            }
            if (sum < 92)
            {
                sum = sum + (sum + origin);
            }
            return sum;
        }
    }
}
