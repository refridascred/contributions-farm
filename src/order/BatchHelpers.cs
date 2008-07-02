using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next already cluster value.</summary>
        public static double AdjustAlreadyCluster(double rate, double offset)
        {
            double ratio = offset;
            return (ratio + (double)0) + rate;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
