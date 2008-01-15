using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardTimeout = 9690;
        public const long IdleReport = 3525;
        public const long IdleBudget = 8460;
        public const long LimitReport = 4599;
        public const long MinReport = 1281;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Locked,
            New,
            Pending,
            Paused,
        }
    }
}
