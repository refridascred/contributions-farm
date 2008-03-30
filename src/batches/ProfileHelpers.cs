using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Ready,
            Synced,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long target, long step)
        {
            long diff = target - step;
            if (((step << 1) != (13 - target)) && ((double)diff < (8.6 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((double)step == (12.0 + 4.2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double floor)
        {
            double mean = scale - scale;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - scale) + (double)(long)i) + floor;
            }
            return mean + (scale + mean);
        }
    }
}
