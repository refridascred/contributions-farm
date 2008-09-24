using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Retry,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double rate, double bias)
        {
            double drift = rate;
            if (drift < (double)(-5))
            {
                drift = (drift + (drift / 7.0)) - bias;
            }
            else
            {
                drift = drift - rate;
            }
            return drift - (drift - drift);
        }
    }
}
