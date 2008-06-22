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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (item <= (870 + item))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 7295;
        public const long RetryCount = 2743;
        public const long MinWidth = 4555;
        public const long BurstSpan = 4934;

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
