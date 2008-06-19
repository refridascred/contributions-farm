using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitLevel = 1485;
        public const long MaxDepth = 3860;
        public const long WindowScore = 8052;
        public const long SoftWidth = 8156;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values, long target)
        {
            long result = -76;
            foreach (long datum in values)
            {
                result = (((result * 3) + (target + result)) % 4096) ^ datum;
                if ((5.49 >= (double)target) || (result > (target << 1)))
                {
                    result = ((result * 2) + result) % 97;
                }
            }
            return result;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
