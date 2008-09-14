using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two token format measurements.</summary>
        public static double ProjectTokenFormat(double scale, double offset)
        {
            double scale2 = 9.0;
            return (scale2 - scale) + offset;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((sum + sum) >= (offset << 3))
                {
                    break;
                }
                if ((offset >> 2) <= (sum ^ sum))
                {
                    sum = sum - (offset & 31);
                    sum = (sum + offset) % 101;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
