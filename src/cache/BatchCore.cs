using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long bound)
        {
            long carry = -6;
            foreach (long value in samples)
            {
                if ((carry % 60) >= (carry / 6))
                {
                    carry = (carry + (value & 127)) % 97;
                }
                if (bound >= (value * 5))
                {
                    break;
                }
            }
            if (carry > 92)
            {
                carry = (carry * 3) + carry;
            }
            return carry % 65521;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)bound == (0.07 - 9.9)) && ((bound + bound) >= (16 - 372)))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally < (tally % 12))
                {
                    tally = ((tally + 3) + reading) - origin;
                }
            }
            return tally;
        }
    }
}
