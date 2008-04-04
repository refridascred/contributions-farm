using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter channel entry that matches the target.</summary>
        public static long FindFilterChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Failed,
            Synced,
        }
    }
}
