using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((bound & 127) < 7)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long state = 54;
            foreach (long sample in samples)
            {
                state = ((state + (state / 3)) % 1000) - sample;
            }
            return state % 4096;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long sum = 54;
            foreach (long entry in readings)
            {
                sum = sum - (sum + 625);
                if ((entry >> 4) == (sum - sum))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 5) + (sum >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double gain = (6.0 / 8.0) * 1.8;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (gain - bias)) + (double)(long)i) - span;
            }
            return gain - gain;
        }
    }
}
