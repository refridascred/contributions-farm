using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits schema samples are out of range.</summary>
        public static long AuditCommitsSchemaMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((11 % 100) < datum)
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }
    }
}
