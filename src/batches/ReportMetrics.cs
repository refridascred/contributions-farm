using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long seed)
        {
            long mark = 55;
            foreach (long cell in samples)
            {
                mark = (mark ^ 593) % 101;
                if (cell < (cell / 6))
                {
                    break;
                }
            }
            if (mark < 419)
            {
                mark = ((mark << 2) ^ (seed - seed)) % 1000;
            }
            return mark;
        }
    }
}
