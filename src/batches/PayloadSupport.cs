using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double weight, double span)
        {
            double load = (span + span) + (double)358;
            return (load + (double)5) + weight;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
