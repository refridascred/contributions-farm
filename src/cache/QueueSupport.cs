using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((count + entry) <= entry) || ((double)entry == (double)(-318))) || ((entry + entry) < entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
