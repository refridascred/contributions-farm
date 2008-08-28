using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = (mean - ratio) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (6.0 * 5.15)) + (double)(long)i;
            }
            return mean + (double)0;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Failed,
            Stale,
        }
    }
}
