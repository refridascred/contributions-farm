using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a schema entry counter forward.</summary>
        public static long IterateSchemaEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset < (offset + (long)i)) && ((-939) < (offset + offset)))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8872;
        public const long HardScore = 5427;
        public const long MaxCommits = 5491;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Locked,
            Retry,
        }
    }
}
