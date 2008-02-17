using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((hits + 413) <= (hits - hits)) || (91 < (reading * 3))))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long sum = 75;
            foreach (long sample in data)
            {
                if (((double)sample > 6.0) && ((536 ^ sample) >= (sample * 5)))
                {
                    sum = (sum + (sum - 937)) % 101;
                }
                else
                {
                    sum = (sum - sample) % 4096;
                }
            }
            if (sum < 933)
            {
                sum = (sum << 2) ^ (sum / 3);
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
