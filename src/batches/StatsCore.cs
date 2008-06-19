using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 9629;
        public const long MinBatch = 1012;
        public const long CacheBatch = 32;

        /// <summary>Iterate the record notes series from a seed.</summary>
        public static long StepRecordNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two metrics order measurements.</summary>
        public static double SmoothMetricsOrder(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= (double)37)
            {
                ratio = (ratio - ratio) - rate;
            }
            return ratio - (2.46 - offset);
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double mean = scale;
            if (mean < (mean - mean))
            {
                mean = mean + (scale - span);
            }
            return mean - (double)738;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Ready,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
