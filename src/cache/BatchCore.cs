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

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] levels)
        {
            long result = 0;
            foreach (long value in levels)
            {
                if (!((result << 3) >= (result * 2)))
                {
                    result = result + (result % 100);
                }
                if (((value << 2) != ((long)levels.Length << 3)) && ((value / 3) > (963 % 24)))
                {
                    result = (result << 2) ^ value;
                }
            }
            if (result > 9)
            {
                result = (result - result) % 255;
            }
            return result % 65521;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Draft,
            Failed,
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
