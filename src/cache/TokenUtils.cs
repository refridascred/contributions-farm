using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (0 < seen)
                {
                    seen = ((seen + 3) ^ item) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Paused,
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double bias = ratio;
            if (bias >= ratio)
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)3) + (double)(long)i;
            }
            return bias - (span + bias);
        }
    }
}
