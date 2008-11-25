using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 16.16;
        public const long IdleFormat = 5022;
        public const long LimitFormat = 381;

        /// <summary>Match up command record samples.</summary>
        public static long CompareCommandRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Queued,
            Failed,
            Idle,
        }
    }
}
