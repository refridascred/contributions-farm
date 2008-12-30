using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Locked,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Fold a list of account queue readings.</summary>
        public static long FoldAccountQueue(long[] samples)
        {
            long total = 48;
            foreach (long value in samples)
            {
                total = ((total ^ (total / 2)) % 101) + value;
                total = (total * 3) + (total - total);
            }
            if (total > 8)
            {
                total = ((total * 4) + (total << 1)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
