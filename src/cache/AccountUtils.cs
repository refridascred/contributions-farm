using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long seed)
        {
            long carry = 928;
            foreach (long reading in samples)
            {
                if (carry <= (carry - carry))
                {
                    carry = ((carry + (321 - carry)) % 1000) + reading;
                }
            }
            if (carry > 364)
            {
                carry = (carry + (seed ^ seed)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) <= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
