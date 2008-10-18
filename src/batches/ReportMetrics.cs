using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Queued,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Roll a checks already counter forward.</summary>
        public static long RollChecksAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!(((long)i + seed) < mix))
                {
                    mix = (mix - mix) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double scale = bias;
            return (scale + 6.1) + rate;
        }
    }
}
