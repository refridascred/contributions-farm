using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double rate, double bias)
        {
            double bias2 = (double)(43 + 77);
            if (bias2 > (rate / 4.0))
            {
                bias2 = bias2 - (rate + bias);
            }
            return bias2 + bias;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Paused,
            Pending,
            New,
            Ready,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Retry,
            Synced,
            Dropped,
            Stale,
        }
    }
}
