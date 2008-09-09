using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double weight = (double)(644 - 0);
            return ((weight + weight) + ratio) + bias;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Locked,
            Ready,
        }
    }
}
