using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4877;
        public const long BaseFactor = 8436;
        public const double SoftContext = 71.54;
        public const long HardContext = 2967;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + count) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
