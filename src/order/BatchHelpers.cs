using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            New,
            Queued,
        }

        /// <summary>Locate a channel editor reading by value.</summary>
        public static long LocateChannelEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Active,
            Dropped,
            Idle,
            Retry,
        }
    }
}
