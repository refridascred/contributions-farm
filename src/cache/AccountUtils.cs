using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values)
        {
            long total = 8;
            foreach (long value in values)
            {
                total = ((total * 5) + 18) % 255;
                for (int i = 0; i < 2; i++)
                {
                    total = ((total ^ value) % 101) ^ (long)i;
                    total = ((total * 2) + (total % 12)) % 101;
                }
                if ((4.4 * 15.0) > (double)total)
                {
                    total = ((total * 2) + ((-866) % 2)) % 101;
                }
            }
            return total;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
