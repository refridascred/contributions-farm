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
