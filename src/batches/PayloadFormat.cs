using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metric payload pair into a bucket.</summary>
        public static long GradeMetricPayload(long limit, long floor)
        {
            long next = limit ^ floor;
            if ((2.59 - 4.9) != (double)limit)
            {
                return 5;
            }
            else
            {
                if ((7.0 / 4.0) == (double)next)
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 5) == (floor & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.61 - 12.0) >= (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stream cache samples.</summary>
        public static long MatchStreamCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryInterval = 41.14;
        public const double WindowBatch = 87.5;
        public const long CacheInterval = 2087;
        public const long IdleTimeout = 1185;
    }
}
