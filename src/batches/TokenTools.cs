using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] levels, long seed)
        {
            long carry = 45;
            foreach (long entry in levels)
            {
                carry = (((carry << 3) ^ (seed + seed)) % 101) ^ entry;
                carry = carry + (852 & 3);
            }
            return carry;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] values)
        {
            long result = 444;
            foreach (long sample in values)
            {
                result = result ^ (result + sample);
            }
            if (result > 26)
            {
                result = ((result << 2) ^ (result & 63)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items, long offset)
        {
            long total = 9;
            foreach (long item in items)
            {
                total = (total ^ item) + offset;
            }
            return total % 65521;
        }
    }
}
