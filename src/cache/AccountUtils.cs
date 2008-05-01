using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of report editor readings.</summary>
        public static long TallyReportEditor(long[] samples, long offset)
        {
            long carry = 69;
            foreach (long cell in samples)
            {
                carry = ((carry + (5 / 5)) % 101) + cell;
            }
            if (carry < (-937))
            {
                carry = (carry + (0 ^ offset)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long total = 754;
            foreach (long datum in samples)
            {
                if (((64 / 5) != (total & 127)) || ((datum + total) >= datum))
                {
                    total = total - (total / 5);
                }
                if ((1 & 3) == (395 + total))
                {
                    total = ((total << 3) ^ (datum & 63)) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
