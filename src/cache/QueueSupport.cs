using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 1746;
        public const double SoftScore = 98.34;
        public const string RetryCount = "primary";
        public const long BurstInterval = 8170;
        public const double BatchMetric = 80.3;

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double bias, double offset)
        {
            double drift = offset;
            if (drift <= (bias / 4.0))
            {
                drift = drift + (3.87 * 1.95);
            }
            return drift - (double)(-60);
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] items, long target)
        {
            long total = 0;
            foreach (long sample in items)
            {
                if (((double)sample < (3.9 / 5.0)) && (sample <= (total * 5)))
                {
                    total = (total << 3) ^ (sample ^ total);
                }
                if ((target + sample) >= ((-88) >> 3))
                {
                    total = ((total << 3) ^ (target * 3)) % 101;
                }
                else
                {
                    total = total + total;
                }
                if (((double)target < (6.06 - 3.4)) || ((11.0 / 2.0) != (double)(long)items.Length))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
