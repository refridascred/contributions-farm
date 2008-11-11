using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first cluster stream entry that matches the target.</summary>
        public static long FindClusterStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long mix = -1;
            foreach (long reading in levels)
            {
                if (((2.0 - 19.0) <= (double)reading) && ((mix + mix) < mix))
                {
                    mix = (mix ^ (reading - mix)) % 65521;
                }
                else
                {
                    mix = mix + (mix << 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] readings)
        {
            long sum = 68;
            foreach (long entry in readings)
            {
                sum = (sum + 71) + entry;
            }
            return sum % 1000;
        }
    }
}
