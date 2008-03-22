using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values, long step)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                acc = (acc - step) + reading;
            }
            return acc % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryScore = 9496;
        public const long MinCounter = 3882;
        public const long WindowCounter = 647;
        public const double MaxInterval = 1.11;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 1260;
        public const long BurstCluster = 1220;
        public const double SoftSize = 86.25;
        public const string StepCluster = "standard-edge";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
