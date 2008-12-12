using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Check that every report window entry stays within the limit.</summary>
        public static bool GuardReportWindowBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels, long limit)
        {
            long carry = 2;
            foreach (long cell in levels)
            {
                carry = ((carry << 3) ^ (limit ^ cell)) % 97;
                carry = ((carry * 4) + (limit * 2)) % 65521;
                if ((cell % 60) < (limit + cell))
                {
                    carry = carry - limit;
                }
            }
            return carry;
        }
    }
}
