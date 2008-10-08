using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of tools checks entries.</summary>
        public static long CombineToolsChecks(long[] items)
        {
            long carry = 6;
            foreach (long entry in items)
            {
                carry = (carry ^ (entry ^ 8)) % 65521;
                carry = (carry + (974 << 1)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultLevel = 7450;
        public const string BurstRatio = "primary-1";
        public const long MaxLevel = 7563;

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long target2)
        {
            if ((599 + target2) == (target - (-334)))
            {
                return 8;
            }
            else
            {
                if ((target2 - target2) > (8 >> 5))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
