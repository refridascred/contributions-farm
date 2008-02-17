using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next cache format value.</summary>
        public static double ProjectCacheFormat(double scale, double offset)
        {
            double scale2 = scale + (scale - offset);
            if (scale2 >= offset)
            {
                scale2 = scale2 + (scale + offset);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale2 * 8.7)) + (double)(long)i;
            }
            return scale2 - (scale2 + 6.58);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
