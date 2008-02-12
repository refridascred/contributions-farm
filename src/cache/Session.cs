using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long DigestGithubfarmReport(long[] samples, long origin)
        {
            long carry = -273;
            foreach (long entry in samples)
            {
                carry = (carry - (entry + 32)) % 65521;
            }
            if (carry < 98)
            {
                carry = ((carry * 3) + (origin + carry)) % 65521;
            }
            return carry % 4096;
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
