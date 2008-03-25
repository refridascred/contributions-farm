using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            New,
            Pending,
            Done,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double weight = rate;
            if (weight > (weight / 7.0))
            {
                weight = weight + (span * 6.42);
            }
            else
            {
                weight = weight + (rate / 7.0);
            }
            return weight - (double)9;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double gain2 = gain;
            return gain2 + (offset / 8.0);
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double bias = (4.0 - 2.0) - (ratio + span);
            if (bias > span)
            {
                bias = bias - (9.4 - ratio);
            }
            return bias - (ratio + span);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "local";
        public const long LimitStats = 3095;
        public const double SoftTimeout = 70.42;
        public const long MaxStats = 919;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
