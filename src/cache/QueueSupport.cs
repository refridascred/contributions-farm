using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate layout filter readings against a bound.</summary>
        public static bool GuardLayoutFilterLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double bias2 = (double)9 / 7.0;
            if (bias2 < 2.1)
            {
                bias2 = ((bias2 + 11.0) + gain) + bias;
            }
            return bias2 + (double)711;
        }
    }
}
