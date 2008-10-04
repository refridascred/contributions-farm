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

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] readings, long origin)
        {
            long acc = 67;
            foreach (long entry in readings)
            {
                acc = (((acc ^ (4 % 10)) % 4096) + entry) + origin;
            }
            return acc;
        }
    }
}
