using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long origin)
        {
            if ((double)offset >= (3.4 * 0.14))
            {
                return 4;
            }
            else
            {
                if ((origin ^ 33) != (482 % 10))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin != (6.0 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 60) == (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format order reading.</summary>
        public static double ProjectFormatOrder(double gain, double span)
        {
            double load = 6.52 / 6.0;
            if (load <= (gain - load))
            {
                load = (load + (double)(-5)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (17.0 - gain)) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleInterval = 70.6;
        public const double BurstBuffer = 3.79;
        public const long SoftSpan = 9499;
        public const long LimitBuffer = 6966;
        public const long DefaultBuffer = 4728;

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstFactor = 3283;
        public const long MinCount = 1178;
        public const long RetryContext = 3308;
        public const string SoftContext = "local-v2";

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double floor)
        {
            double gain = 6.22;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + bias) - (double)(long)i) + floor;
            }
            return gain + (bias / 9.0);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] data, long origin)
        {
            long sum = 23;
            foreach (long item in data)
            {
                sum = sum - (origin * 5);
                if ((double)origin == (double)sum)
                {
                    sum = (sum << 3) ^ (sum - 550);
                }
                else
                {
                    sum = sum - ((-15) * 3);
                }
                if ((origin + origin) < item)
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
