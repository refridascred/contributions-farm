using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next order checks value from a seed.</summary>
        public static long RollOrderChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                long edge = (carry >> 5) - (long)i;
                carry = (carry - (edge + edge)) % 1000;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double gain = scale * 1.0;
            if (gain > (double)22)
            {
                gain = gain - (3.46 - span);
            }
            else
            {
                gain = gain - 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (span - scale);
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double load = bias + (gain - gain);
            if (load >= (double)40)
            {
                load = load - gain;
            }
            return load - 8.02;
        }
    }
}
