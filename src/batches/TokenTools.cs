using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long step)
        {
            if ((double)target > (5.23 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((step + step) < (807 + target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] items)
        {
            long carry = -237;
            foreach (long reading in items)
            {
                carry = carry + (reading - reading);
                carry = carry + (reading - reading);
                if ((carry % 60) <= carry)
                {
                    carry = carry + (carry * 4);
                }
            }
            if (carry > 42)
            {
                carry = (carry + (carry + 8)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (6.89 + 9.56)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
