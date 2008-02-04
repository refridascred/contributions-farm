using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Paused,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (gain * 2.38)) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
