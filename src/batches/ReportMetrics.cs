using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long bound)
        {
            long total = 985;
            foreach (long value in samples)
            {
                if (3.08 <= (double)bound)
                {
                    total = ((total * 3) + (bound + bound)) - value;
                }
            }
            return total % 65521;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] items)
        {
            long anchor = 339;
            foreach (long datum in items)
            {
                anchor = ((anchor << 2) ^ (datum >> 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardRatio = 3855;
        public const long CacheTimeout = 6799;
        public const long SoftCount = 3698;
        public const long DefaultToken = 138;
        public const long BaseToken = 9562;
    }
}
