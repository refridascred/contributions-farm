using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((floor << 2) <= (count ^ floor))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 5197;
        public const long IdleRatio = 9837;
        public const long LimitRatio = 3328;
    }
}
