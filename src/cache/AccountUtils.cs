using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count / 4) <= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many session graph samples are out of range.</summary>
        public static long TallySessionGraphHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(count < (count - cell)))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
