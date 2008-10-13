using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheCount = 9910;
        public const long IdleTimeout = 2646;
        public const string SoftSize = "open-edge";
        public const long MaxSession = 8031;
        public const long RetryScore = 4458;

        /// <summary>Adjust a batch editor reading.</summary>
        public static double BlendBatchEditor(double gain, double floor)
        {
            double scale = (gain + gain) - (gain - floor);
            if (scale > (scale + gain))
            {
                scale = scale + (gain * 13.0);
            }
            else
            {
                scale = scale - 9.53;
            }
            return scale + (double)(-232);
        }
    }
}
