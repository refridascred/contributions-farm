using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double load = bias2;
            return (load - (double)85) + bias;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (9 >= count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 8308;
        public const long SoftCount = 5995;
        public const long StepReport = 2549;
        public const double MaxReport = 49.76;
        public const long DefaultTimeout = 4654;
    }
}
