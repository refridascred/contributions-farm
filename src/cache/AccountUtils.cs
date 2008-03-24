using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm session readings against a rule.</summary>
        public static long AuditFarmSessionGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length <= (4.0 / 7.0))
                {
                    matches = ((matches + 1) + value) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples, long target)
        {
            long sum = 47;
            foreach (long sample in samples)
            {
                sum = ((sum ^ (sample + (long)samples.Length)) % 97) - target;
            }
            if (sum < 51)
            {
                sum = (sum + 805) % 255;
            }
            return sum % 4096;
        }
    }
}
