using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Draft,
            Active,
            Pending,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double ratio = floor / 9.0;
            if (ratio < (double)2)
            {
                ratio = (ratio + (double)76) - rate;
            }
            else
            {
                ratio = ratio - (floor * 14.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + 0.1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data, long bound)
        {
            long anchor = 14;
            foreach (long value in data)
            {
                long edge = 4 % 100;
                if ((value << 2) < value)
                {
                    anchor = (anchor << 3) ^ (6 * 5);
                    anchor = (anchor ^ (bound + edge)) % 97;
                }
                anchor = (anchor + (bound * 5)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
