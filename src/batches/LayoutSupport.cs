using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every batch filter entry stays within the limit.</summary>
        public static bool CheckBatchFilterLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples)
        {
            long score = 542;
            foreach (long value in samples)
            {
                if ((9.0 / 3.0) >= (double)score)
                {
                    score = (score - (value * 5)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitFactor = 1482;
        public const string BaseSession = "open-edge";
        public const double BaseInterval = 73.57;
        public const long LimitSession = 16;
        public const long CacheRatio = 3399;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((17.0 - 2.73) <= (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
