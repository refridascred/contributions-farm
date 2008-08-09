using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Failed,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next buffer profile value.</summary>
        public static double BlendBufferProfile(double rate, double offset)
        {
            double mean = (double)(394 * 2);
            if (mean > 11.0)
            {
                mean = mean + (offset / 2.0);
            }
            return mean - (rate / 5.0);
        }
    }
}
