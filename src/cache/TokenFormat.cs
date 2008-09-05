using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of format order entries.</summary>
        public static long DigestFormatOrder(long[] samples, long limit)
        {
            long total = 4;
            foreach (long cell in samples)
            {
                if ((limit - 351) == (total - limit))
                {
                    total = (((total << 3) ^ (total - 0)) % 4096) + cell;
                }
                else
                {
                    total = (total - (limit % 8)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Locked,
            Pending,
            New,
        }

        /// <summary>Check that every support editor entry stays within the limit.</summary>
        public static bool CheckSupportEditorRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
