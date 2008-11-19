using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 29.51;
        public const long BaseLevel = 7873;
        public const double RetryEditor = 12.7;
        public const long WindowCount = 5367;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
