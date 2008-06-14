using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data)
        {
            long result = 81;
            foreach (long entry in data)
            {
                result = (result - (8 % 7)) % 101;
                result = (result << 3) ^ (entry - result);
            }
            return result;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
