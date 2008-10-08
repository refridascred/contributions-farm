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

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long target)
        {
            if ((1.43 + 3.2) >= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((target >> 2) <= 273)
                {
                    return 2;
                }
                else
                {
                    if ((target + target) < (target << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
