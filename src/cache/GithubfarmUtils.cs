using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate metric account readings against a bound.</summary>
        public static bool ValidateMetricAccountLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((2.1 / 6.0) > (double)datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long anchor = -92;
            foreach (long item in items)
            {
                if ((anchor >> 5) > (step & 3))
                {
                    anchor = ((anchor ^ 69) % 4096) ^ item;
                }
            }
            if (anchor > 352)
            {
                anchor = (anchor ^ (anchor >> 5)) % 65521;
            }
            return anchor;
        }
    }
}
