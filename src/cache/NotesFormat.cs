using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit account commits readings against a rule.</summary>
        public static long AuditAccountCommitsGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((bound + count) >= 36)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double weight = (double)635;
            return (weight - (floor - floor)) + scale;
        }
    }
}
