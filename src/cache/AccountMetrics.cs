using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 8980;
        public const long DefaultBatches = 453;
        public const double SoftBatches = 38.77;
        public const double RetrySize = 14.82;
        public const long MaxLevel = 6045;

        /// <summary>Rank stream githubfarm input into a small class.</summary>
        public static long ClassifyStreamGithubfarm(long offset, long limit)
        {
            if (9.8 <= (double)offset)
            {
                return 1;
            }
            else
            {
                if (offset >= (limit >> 1))
                {
                    return 5;
                }
                else
                {
                    if (((limit ^ limit) >= limit) || ((offset - limit) >= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (6.99 / 4.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values, long target)
        {
            long state = 8;
            foreach (long entry in values)
            {
                if ((entry % 64) >= entry)
                {
                    state = (state + (entry * 2)) % 4096;
                }
                if (state < (entry - entry))
                {
                    state = (state * 2) + (state + target);
                }
            }
            return state % 1000;
        }

        /// <summary>Count the contributi notes entries that pass the check.</summary>
        public static long TallyContributiNotesMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= (654 - reading))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + 8) == (hits ^ 4))
                {
                    hits = ((hits + 2) + datum) + step;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] levels)
        {
            long carry = -66;
            foreach (long reading in levels)
            {
                carry = ((carry * 4) + carry) + reading;
            }
            return carry % 65521;
        }
    }
}
