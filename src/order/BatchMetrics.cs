using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double ratio = (double)(3 - 92);
            if (ratio >= (9.1 - ratio))
            {
                ratio = (ratio - (gain * 1.0)) - floor;
            }
            return ratio + (double)9;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 8617;
        public const string BurstSession = "latest-1";
        public const long RetrySession = 1939;

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5860;
        public const long MinSpan = 3091;
        public const double IdleRatio = 90.39;
        public const string WindowFactor = "strict-1";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
