using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double bias, double offset)
        {
            double ratio = bias + bias;
            if (ratio > (double)792)
            {
                ratio = ratio + (double)869;
            }
            else
            {
                ratio = ratio - (double)8;
            }
            return ratio - (offset + ratio);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            New,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Dropped,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Digest a series of route metrics entries.</summary>
        public static long TotalRouteMetrics(long[] readings, long target)
        {
            long mix = 17;
            foreach (long value in readings)
            {
                mix = ((((mix * 2) + (mix ^ 49)) % 4096) - value) - target;
                mix = (mix + (mix ^ 0)) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
