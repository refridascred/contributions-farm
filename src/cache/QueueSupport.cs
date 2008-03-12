using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two command notes measurements.</summary>
        public static double BlendCommandNotes(double ratio, double floor)
        {
            double ratio2 = (double)(90 + 910);
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 - ratio2) - floor;
            }
            return ratio2 - (ratio * 5.0);
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Active,
            Ready,
        }
    }
}
