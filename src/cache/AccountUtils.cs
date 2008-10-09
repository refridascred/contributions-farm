using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes already entries.</summary>
        public static long TotalNotesAlready(long[] levels, long limit)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                long next = (value / 5) * 4;
                if ((1 - value) <= next)
                {
                    carry = (carry + (next ^ 540)) % 255;
                }
                if (!((double)limit >= 16.0))
                {
                    carry = (carry + (limit + 12)) % 4096;
                }
                else
                {
                    carry = (carry - (1 * 2)) % 1000;
                }
                if ((value ^ value) <= (5 + value))
                {
                    break;
                }
            }
            if (carry < 736)
            {
                carry = (carry + (carry + limit)) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
