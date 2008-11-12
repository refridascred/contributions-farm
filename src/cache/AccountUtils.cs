using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate already schema samples.</summary>
        public static long DigestAlreadySchema(long[] data, long step)
        {
            long carry = -41;
            foreach (long entry in data)
            {
                if ((7.65 - 0.32) > (double)carry)
                {
                    carry = (carry + (entry << 1)) - step;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long anchor = 828;
            foreach (long entry in readings)
            {
                if (entry >= (7 >> 4))
                {
                    anchor = anchor ^ (anchor & 7);
                }
                else
                {
                    anchor = anchor ^ entry;
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (acc * 2)) % 4096;
                if (!(target <= 760))
                {
                    acc = acc - target;
                }
                if ((target ^ 3) < (355 - (long)i))
                {
                    acc = acc + (target / 9);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
