using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double bias = offset;
            if (bias < (offset + bias))
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (gain * 8.73)) + (double)(long)i;
            }
            return bias - 0.33;
        }

        /// <summary>Match up notes stream samples.</summary>
        public static long MatchNotesStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of token channel readings.</summary>
        public static long CompareTokenChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
