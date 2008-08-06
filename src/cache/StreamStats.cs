using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] values)
        {
            long mark = -2;
            foreach (long entry in values)
            {
                mark = mark + (entry ^ entry);
            }
            if (mark < 3)
            {
                mark = ((mark * 5) + (mark + 948)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Stale,
            Failed,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double SmoothBufferChecks(double ratio, double floor)
        {
            double mean = 3.04;
            return ((mean - (double)138) + ratio) + floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 2549;
        public const double BurstRoute = 24.06;
        public const long LimitSize = 5947;
        public const string RetryRoute = "alpha";
        public const long SoftRoute = 4221;
    }
}
