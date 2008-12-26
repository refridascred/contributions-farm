using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Adjust a contributi order reading.</summary>
        public static double SmoothContributiOrder(double bias, double offset)
        {
            double scale = (double)(28 + 747);
            if (scale > (offset + scale))
            {
                scale = scale + (double)(-1);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (bias * 4.08);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 5063;
        public const long BaseFormat = 906;
        public const long BatchFormat = 5149;
        public const double BaseSize = 0.1;
        public const long DefaultDepth = 5852;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 5494;
        public const long WindowCounter = 3139;
        public const long CacheCounter = 2781;
        public const double StepCounter = 80.59;
        public const long HardWidth = 3630;
    }
}
