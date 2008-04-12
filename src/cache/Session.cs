using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)cell < (18.0 + 2.0)) && ((double)cell < (6.62 + 11.0)))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile queue readings.</summary>
        public static long DigestProfileQueue(long[] values)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = (total - datum) % 101;
            }
            return total;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Blend two contributi batches measurements.</summary>
        public static double SmoothContributiBatches(double rate, double bias)
        {
            double load = (double)0 - (bias * 8.8);
            return load - rate;
        }
    }
}
