using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Pending,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double scale, double span)
        {
            double gain = scale;
            return (gain + scale) + span;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i - 52) > anchor))
                {
                    anchor = ((anchor * 4) + ((long)i & 7)) % 255;
                    anchor = (anchor ^ (origin - (-4))) % 101;
                }
                anchor = (anchor ^ (38 ^ anchor)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
