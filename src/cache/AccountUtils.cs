using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next commits already value.</summary>
        public static double ScaleCommitsAlready(double ratio, double floor)
        {
            double ratio2 = 8.9;
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (((ratio2 + 1.67) - (double)(long)i) + ratio) + floor;
            }
            return ratio2 + (double)29;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] samples)
        {
            long acc = 813;
            foreach (long value in samples)
            {
                acc = (acc ^ (value - value)) % 1000;
            }
            return acc;
        }
    }
}
