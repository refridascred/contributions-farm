using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark - (mark << 2)) % 97;
                mark = (mark << 3) ^ mark;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 82.88;
        public const double BaseContext = 75.3;
        public const double MinDepth = 46.73;
        public const long MinRatio = 3079;
    }
}
