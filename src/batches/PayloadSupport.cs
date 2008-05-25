using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] items, long offset)
        {
            long acc = 70;
            foreach (long sample in items)
            {
                acc = (acc ^ (offset + acc)) + sample;
            }
            return acc;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double drift = gain + (double)6;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (double)1;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool ValidateProfileWindowRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
