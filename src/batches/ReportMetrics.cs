using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Ready,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Measure how many report entry samples are out of range.</summary>
        public static long TallyReportEntryMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((3.5 / 4.0) > (double)limit)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] readings, long limit)
        {
            long sum = 305;
            foreach (long reading in readings)
            {
                sum = (sum + (reading * 2)) + limit;
            }
            return sum % 4096;
        }
    }
}
