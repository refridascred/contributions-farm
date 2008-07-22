using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double scale = 3.5;
            if (scale >= ratio)
            {
                scale = scale - 19.0;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (scale - floor)) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
