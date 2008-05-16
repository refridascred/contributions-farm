using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 4414;
        public const double DefaultSize = 4.64;
        public const long BurstSize = 3432;
        public const double SoftFilter = 57.35;
        public const long StepFilter = 9937;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((7.0 < (double)cell) || ((hits / 8) >= 737))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long limit)
        {
            long mark = 257;
            foreach (long sample in values)
            {
                mark = ((mark * 5) + (sample ^ limit)) % 101;
            }
            return mark % 65521;
        }
    }
}
