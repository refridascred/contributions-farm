using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Dropped,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Find the first stream batches entry that matches the target.</summary>
        public static long LocateStreamBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long floor)
        {
            long edge = step + floor;
            if (edge > (752 << 2))
            {
                return 0;
            }
            else
            {
                if ((floor / 2) > (step << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge > (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Pending,
            Active,
        }
    }
}
