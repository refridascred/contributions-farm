using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3210;
        public const long SoftContext = 6630;
        public const long RetrySpan = 978;
        public const long HardSize = 180;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((floor & 255) < count) && ((count ^ floor) >= ((-4) + (long)data.Length)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
