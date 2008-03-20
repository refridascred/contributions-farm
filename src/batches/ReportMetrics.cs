using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of contributi commits entries.</summary>
        public static long TotalContributiCommits(long[] data, long origin)
        {
            long total = 46;
            foreach (long datum in data)
            {
                total = ((total - (2 ^ total)) + datum) + origin;
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total & 63);
            }
            return total % 65521;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Synced,
            Pending,
            Stale,
        }
    }
}
