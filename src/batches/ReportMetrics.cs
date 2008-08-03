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

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultRatio = 33.18;
        public const long BatchFactor = 1856;
        public const double DefaultSchema = 74.85;
        public const double BurstSchema = 6.09;

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
