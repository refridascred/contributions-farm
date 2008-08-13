using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings, long target)
        {
            long state = 14;
            foreach (long reading in readings)
            {
                if (((reading ^ target) != (8 + reading)) || ((-182) <= state))
                {
                    state = (state << 3) ^ reading;
                }
                if ((reading % 2) == ((-465) - state))
                {
                    break;
                }
            }
            if (state < 7)
            {
                state = state - (state >> 5);
            }
            return state;
        }
    }
}
