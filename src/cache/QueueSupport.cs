using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double drift = span;
            if (drift <= (double)7)
            {
                drift = (drift + 0.5) + ratio;
            }
            return drift + (drift - span);
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Locked,
            Synced,
            Closed,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
