using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] samples)
        {
            long carry = -77;
            foreach (long reading in samples)
            {
                carry = ((carry << 3) ^ (reading + carry)) % 97;
            }
            if (carry > 93)
            {
                carry = ((carry * 5) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Draft,
            Done,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value + tally) < (value << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits > 15.0)
                {
                    hits = ((hits + 1) + value) - floor;
                }
            }
            return hits;
        }
    }
}
