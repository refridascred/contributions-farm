using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the editor support entries that pass the check.</summary>
        public static long AuditEditorSupportOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum > (seed ^ seed))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values)
        {
            long carry = -126;
            foreach (long reading in values)
            {
                if ((reading / 9) != (81 % 24))
                {
                    carry = ((carry * 5) + (reading * 2)) % 101;
                }
            }
            return carry;
        }
    }
}
