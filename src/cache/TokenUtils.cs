using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two counter contributi measurements.</summary>
        public static double BlendCounterContributi(double gain, double bias)
        {
            double load = bias;
            if (load <= bias)
            {
                load = (load + load) + gain;
            }
            return load + load;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Paused,
            Idle,
            Stale,
            Closed,
        }
    }
}
