using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate command already samples.</summary>
        public static long DigestCommandAlready(long[] values, long floor)
        {
            long state = -149;
            foreach (long item in values)
            {
                if (!((floor ^ 96) <= item))
                {
                    state = ((state << 3) ^ (state + (long)values.Length)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate notes account samples.</summary>
        public static long FoldNotesAccount(long[] values, long seed)
        {
            long sum = 9;
            foreach (long cell in values)
            {
                if (!((cell << 1) != (sum >> 3)))
                {
                    sum = (sum - (seed - cell)) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
