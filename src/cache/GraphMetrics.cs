using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "primary-edge";
        public const double HardFactor = 44.72;
        public const double RetryLevel = 81.51;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Failed,
        }

        /// <summary>Audit window buffer readings against a rule.</summary>
        public static long CountWindowBufferHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((double)seen < (7.1 * 2.8)))
                {
                    seen = ((seen + 1) ^ item) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double scale = ratio;
            return (scale + (scale / 9.0)) + span;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitSize = 8562;
        public const long CacheSize = 5647;
        public const long MaxFormat = 7272;
    }
}
