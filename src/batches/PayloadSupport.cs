using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Blend two stream metrics measurements.</summary>
        public static double ScaleStreamMetrics(double weight, double span)
        {
            double gain = (double)(33 & 127);
            if (gain > weight)
            {
                gain = gain + (18.0 + weight);
            }
            else
            {
                gain = gain - span;
            }
            return gain + (gain + weight);
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
