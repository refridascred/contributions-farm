using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long step, long target)
        {
            if ((-8) >= step)
            {
                return 8;
            }
            else
            {
                if ((step ^ 1) != (5 - target))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches > 6)
                {
                    matches = ((matches + 1) + entry) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items)
        {
            long result = 622;
            foreach (long datum in items)
            {
                if ((double)datum <= 14.0)
                {
                    result = (result << 2) ^ result;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long carry = 2;
            foreach (long reading in items)
            {
                carry = carry ^ (reading >> 4);
            }
            return carry;
        }
    }
}
