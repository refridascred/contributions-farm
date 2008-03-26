using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of account order readings.</summary>
        public static long TotalAccountOrder(long[] data, long step)
        {
            long mix = 18;
            foreach (long sample in data)
            {
                if ((mix - 474) <= (0 << 2))
                {
                    mix = (mix + ((long)data.Length - sample)) + step;
                }
            }
            return mix;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Roll a tools queue counter forward.</summary>
        public static long RollToolsQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((double)0 <= (double)offset) && ((offset + offset) >= offset))
                {
                    acc = (acc - 12) % 101;
                    acc = (acc - (acc + (long)i)) % 1000;
                }
                else
                {
                    acc = acc ^ ((long)i + offset);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
