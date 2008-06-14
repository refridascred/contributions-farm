using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long CountFarmWindowOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((0.2 + 19.0) < (double)seen) || ((value & 15) >= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
