using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                if (reading <= mix)
                {
                    mix = mix - reading;
                }
            }
            if (mix > 455)
            {
                mix = (mix ^ (mix << 2)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double drift = gain * 3.5;
            return drift - (span + gain);
        }
    }
}
