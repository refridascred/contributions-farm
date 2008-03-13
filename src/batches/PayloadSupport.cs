using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next format notes value from a seed.</summary>
        public static long DeriveFormatNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((value >> 2) <= (count / 8)) && ((11 + value) < (value << 1))) && ((62 ^ value) <= (value - count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
