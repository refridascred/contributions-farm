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

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double scale, double floor)
        {
            double drift = 9.1;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - floor) + (double)(long)i) - scale;
            }
            return drift - floor;
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
