using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Closed,
            Paused,
        }
    }
}
