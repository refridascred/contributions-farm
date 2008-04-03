using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) != (cell % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank metrics cache input into a small class.</summary>
        public static long BucketMetricsCache(long limit, long bound)
        {
            if ((bound % 24) <= (bound + limit))
            {
                return 3;
            }
            else
            {
                if (((limit + limit) != (bound + bound)) && (limit <= (limit - bound)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
