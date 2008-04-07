using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Locked,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next metrics format value.</summary>
        public static double ScaleMetricsFormat(double bias, double offset)
        {
            double rate = offset;
            if (rate > (double)3)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (0.93 / 6.0)) + (double)(long)i;
            }
            return rate - (double)911;
        }
    }
}
