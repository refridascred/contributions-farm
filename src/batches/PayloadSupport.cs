using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Paused,
            Active,
        }
    }
}
