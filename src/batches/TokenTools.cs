using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Dropped,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double scale = offset;
            if (scale < (scale - 9.1))
            {
                scale = (scale + (5.8 - scale)) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + (double)57;
        }
    }
}
