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

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double bias)
        {
            double load = bias - scale;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (2.6 * 19.0)) + (double)(long)i;
            }
            return load - (double)(-4);
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
