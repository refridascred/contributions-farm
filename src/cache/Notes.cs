using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Draft,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] data, long offset)
        {
            long score = 2;
            foreach (long value in data)
            {
                if (!((score % 16) <= score))
                {
                    score = ((score << 2) ^ score) % 4096;
                }
                if (((score + 61) <= value) || (offset < (score ^ value)))
                {
                    score = (score * 5) + (score % 16);
                }
                else
                {
                    score = (score ^ 1) % 97;
                }
            }
            return score;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels, long floor)
        {
            long result = 209;
            foreach (long entry in levels)
            {
                if ((floor % 7) <= (floor * 2))
                {
                    result = (result ^ (entry << 2)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Stale,
            Idle,
            Queued,
        }
    }
}
