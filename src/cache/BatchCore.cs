using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a contributi editor figure with a bias.</summary>
        public static double ScaleContributiEditor(double weight, double bias)
        {
            double drift = (double)(144 << 2);
            if (drift <= drift)
            {
                drift = (drift + weight) - bias;
            }
            else
            {
                drift = drift + weight;
            }
            return drift + (double)23;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
