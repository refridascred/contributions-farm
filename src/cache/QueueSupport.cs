using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Paused,
            New,
            Idle,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long acc = -671;
            foreach (long sample in values)
            {
                acc = (acc ^ (49 - acc)) ^ sample;
                if (acc < (acc - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Pending,
            Closed,
            Done,
            Locked,
        }
    }
}
