using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a metric layout counter forward.</summary>
        public static long IterateMetricLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Synced,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long CountTokenCounterGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading ^ seen) >= (seen ^ reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepSpan = "local";
        public const long CacheRoute = 9355;
        public const long SoftRoute = 2712;
    }
}
