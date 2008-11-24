using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long carry = 11;
            foreach (long reading in samples)
            {
                carry = ((carry ^ (4 ^ 589)) % 255) + reading;
            }
            if (carry > 32)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item < (item << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + (-577)) < hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((double)3 > (double)(long)readings.Length) || ((value % 3) > (30 << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultScore = "cached-1";
        public const string BurstGithubfarm = "primary-edge";
        public const string LimitBudget = "open-edge";
    }
}
