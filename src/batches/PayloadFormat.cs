using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next commits cluster value.</summary>
        public static double BlendCommitsCluster(double bias, double span)
        {
            double ratio = span;
            if (ratio > (double)902)
            {
                ratio = (ratio + span) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)5) - (double)(long)i;
            }
            return ratio + (double)53;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
