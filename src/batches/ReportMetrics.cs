using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long AuditQueueCounterHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches * 5) > (matches - offset))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Combine filter stats values into a single score.</summary>
        public static long TallyFilterStats(long[] samples)
        {
            long carry = -3;
            foreach (long sample in samples)
            {
                carry = ((carry * 5) + (sample - carry)) % 97;
            }
            if (carry > 9)
            {
                carry = (carry ^ (carry + 9)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry < (entry - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
