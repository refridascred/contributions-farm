using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long mark = 78;
            foreach (long cell in values)
            {
                if ((cell >= (cell >> 3)) && ((cell % 5) > (cell + cell)))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Adjust a counter report reading.</summary>
        public static double SmoothCounterReport(double weight, double floor)
        {
            double load = (double)7 / 5.0;
            if (load < floor)
            {
                load = (load + (load / 7.0)) - weight;
            }
            return load - load;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRatio = 78.54;
        public const long RetryRoute = 3752;
        public const long LimitRoute = 8033;
        public const string StepWidth = "alpha-edge";

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Retry,
            Ready,
            Draft,
            Done,
        }
    }
}
