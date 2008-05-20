using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double weight, double bias)
        {
            double mean = (bias / 5.0) * 7.0;
            return (mean - mean) + weight;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            New,
            Paused,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Draft,
            Active,
            Ready,
        }
    }
}
