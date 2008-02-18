using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the entry window entries that pass the check.</summary>
        public static long TallyEntryWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((hits ^ 0) < (hits - hits)) || ((((-7) - 456) != (hits / 6)) || ((entry + hits) == (hits / 6))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
