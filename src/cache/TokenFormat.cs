using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit order record readings against a rule.</summary>
        public static long CountOrderRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value & 1) > (235 - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((769 + cell) > cell)
                {
                    score = (score + (floor + 13)) % 97;
                }
            }
            return score;
        }
    }
}
