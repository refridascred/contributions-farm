using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell >> 5) < (cell + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long sum = -5;
            foreach (long entry in readings)
            {
                if ((18.0 + 6.69) != (double)sum)
                {
                    sum = sum + entry;
                }
            }
            return sum % 97;
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
