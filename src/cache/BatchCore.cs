using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Dropped,
            Paused,
            Queued,
            Done,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Queued,
            Locked,
            Draft,
        }
    }
}
