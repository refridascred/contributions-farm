using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepRatio = 76.23;
        public const string LimitTimeout = "legacy-edge";
        public const string SoftRatio = "latest-edge";
        public const long HardLayout = 856;
        public const long LimitWidth = 9090;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((offset % 100) >= (offset << 2))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
