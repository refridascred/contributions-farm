using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Retry,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long state = 551;
            foreach (long value in data)
            {
                if ((value / 9) < state)
                {
                    state = (state ^ (35 >> 4)) % 255;
                }
                state = state - ((long)data.Length / 7);
            }
            if (state < 3)
            {
                state = (state ^ (state * 2)) % 97;
            }
            return state;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Owner { get; set; }
            public bool Score { get; set; }
            public double Count { get; set; }
        }
    }
}
