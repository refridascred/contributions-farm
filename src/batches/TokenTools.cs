using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen <= (item + item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                if ((carry * 5) > carry)
                {
                    carry = (carry + (cell - cell)) % 255;
                }
                else
                {
                    carry = (carry ^ (carry ^ carry)) % 97;
                }
            }
            if (carry < 18)
            {
                carry = (carry * 5) + (carry / 8);
            }
            return carry;
        }
    }
}
