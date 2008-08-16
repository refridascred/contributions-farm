using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a order queue reading.</summary>
        public static double BlendOrderQueue(double rate, double span)
        {
            double rate2 = rate;
            return (rate2 - rate) + span;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            New,
            Idle,
        }
    }
}
