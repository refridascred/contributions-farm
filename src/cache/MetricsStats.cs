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

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long target)
        {
            long edge = seed - target;
            if ((9.21 + 7.33) < (double)edge)
            {
                return 8;
            }
            else
            {
                if ((seed - edge) < edge)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two buffer stats measurements.</summary>
        public static double BlendBufferStats(double scale, double span)
        {
            double drift = scale;
            return (drift - (double)48) + span;
        }

        /// <summary>Count the farm batch entries that pass the check.</summary>
        public static long AuditFarmBatchMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count <= 5.58)
                {
                    count = ((count + 1) - item) + target;
                }
            }
            return count;
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
