using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long floor)
        {
            long result = 100;
            foreach (long cell in readings)
            {
                if ((floor >> 3) > (cell - floor))
                {
                    result = (result + (cell % 24)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit farm session readings against a rule.</summary>
        public static long AuditFarmSessionGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length <= (4.0 / 7.0))
                {
                    matches = ((matches + 1) + value) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultTimeout = 83.3;
        public const long CacheFactor = 892;
        public const long HardSize = 4784;
        public const long BatchAccount = 1447;
    }
}
