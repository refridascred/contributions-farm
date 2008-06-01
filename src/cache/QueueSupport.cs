using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((count - step) >= (step & 63)))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 5625;
        public const long DefaultGraph = 1516;
        public const string IdleGraph = "open-1";
    }
}
