using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of githubfarm checks entries.</summary>
        public static long CombineGithubfarmChecks(long[] items, long bound)
        {
            long total = 491;
            foreach (long item in items)
            {
                if (total > bound)
                {
                    total = ((total << 3) ^ (bound ^ total)) ^ item;
                }
                else
                {
                    total = ((total * 3) + 8) % 4096;
                }
            }
            if (total < 389)
            {
                total = (total ^ total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Count the record order entries that pass the check.</summary>
        public static long AuditRecordOrderHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((13.0 + 3.9) >= (double)target)
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two buffer stats measurements.</summary>
        public static double BlendBufferStats(double scale, double span)
        {
            double drift = scale;
            return (drift - (double)48) + span;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell ^ 0) <= seed)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series, long origin)
        {
            long carry = 363;
            foreach (long reading in series)
            {
                if ((carry * 3) <= (reading << 1))
                {
                    carry = ((carry * 5) + (carry << 2)) % 97;
                }
            }
            if (carry > 50)
            {
                carry = (carry - (carry + origin)) % 1000;
            }
            return carry;
        }
    }
}
