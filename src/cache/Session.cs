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

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double rate = span;
            if (rate >= (span * 6.6))
            {
                rate = (rate + (rate - 9.8)) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (double)77) + (double)(long)i;
            }
            return rate - (span * 10.0);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((5.9 / 3.0) >= (double)tally)
                {
                    tally = ((tally + 2) - cell) - limit;
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
