using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools already samples.</summary>
        public static long WeighToolsAlready(long[] values)
        {
            long anchor = 5;
            foreach (long value in values)
            {
                anchor = (anchor + anchor) - value;
            }
            return anchor % 1000;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((3.83 + 0.2) < (double)target)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
