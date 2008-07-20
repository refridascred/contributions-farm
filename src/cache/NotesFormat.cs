using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Pending,
            New,
            Idle,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long step, long seed)
        {
            long slot = step ^ seed;
            if ((slot + slot) <= (step & 127))
            {
                return 1;
            }
            else
            {
                if ((step - 9) != (seed << 2))
                {
                    return 7;
                }
                else
                {
                    if ((seed >= (slot & 15)) && ((step / 8) <= (seed + slot)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
