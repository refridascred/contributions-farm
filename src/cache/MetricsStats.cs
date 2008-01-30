using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + tally) <= sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(cell >= (hits / 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels)
        {
            long carry = 87;
            foreach (long item in levels)
            {
                carry = carry - carry;
                carry = carry - (item & 7);
                if ((item - carry) != (carry * 4))
                {
                    carry = (carry * 5) + item;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long carry = 437;
            foreach (long cell in data)
            {
                if ((403 % 12) <= (carry % 3))
                {
                    carry = (carry ^ (45 << 3)) ^ cell;
                }
                else
                {
                    carry = ((carry * 4) + (carry % 5)) % 4096;
                }
            }
            if (carry > 0)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }
    }
}
