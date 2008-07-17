using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 2372;
        public const double SoftBuffer = 56.49;
        public const long LimitBuffer = 6531;
        public const double HardBuffer = 4.05;
        public const double BatchSpan = 32.72;

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double scale = 7.2;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (2.0 + ratio)) + (double)(long)i) + floor;
            }
            return scale - (double)8;
        }

        /// <summary>Classify a window graph pair into a bucket.</summary>
        public static long BucketWindowGraph(long step, long step2)
        {
            long cur = step - step2;
            if (((5.26 + 2.9) == (double)cur) || ((step << 3) > (cur / 7)))
            {
                return 6;
            }
            else
            {
                if (step2 < (step2 ^ cur))
                {
                    return 8;
                }
                else
                {
                    if (!((step2 - step) != (step2 / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheSpan = 30.99;
        public const long CacheToken = 5779;
        public const double BaseCount = 31.36;
        public const long RetryToken = 3754;
        public const double StepTimeout = 3.35;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
