using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Done,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell % 8) > (limit - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseScore = 2793;
        public const string HardWidth = "local-edge";
        public const long DefaultSize = 6580;
    }
}
