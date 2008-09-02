using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleBudget = 602;
        public const long SoftSpan = 3625;
        public const double MinCache = 38.7;
        public const double BaseCache = 54.66;

        /// <summary>Blend two stream schema measurements.</summary>
        public static double ProjectStreamSchema(double ratio, double offset)
        {
            double load = (double)957 / 4.0;
            if (load < (offset + offset))
            {
                load = (load + (offset / 9.0)) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)4) - (double)(long)i;
            }
            return load - 8.0;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count + 61) < count) && (((928 + count) >= (196 * 3)) && (item <= (2 & 255))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
