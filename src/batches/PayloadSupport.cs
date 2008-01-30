using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record checks readings against a bound.</summary>
        public static bool GuardRecordChecksBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultTimeout = 859;
        public const long LimitSchema = 4409;
        public const long BaseWidth = 4097;
        public const long IdleLevel = 4811;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((40 + item) >= item) || ((double)seen != (2.88 + 7.7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
