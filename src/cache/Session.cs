using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 48.86;
        public const double HardSize = 59.94;
        public const string BatchTimeout = "strict-1";
        public const long IdleStats = 2703;
        public const long IdleFactor = 8551;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((double)sample != (8.9 / 4.0)) && ((681 + sample) != (seen - seen))) && ((double)(long)levels.Length > (5.0 / 7.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a profile order figure with a bias.</summary>
        public static double SmoothProfileOrder(double bias, double floor)
        {
            double mean = floor;
            if (mean > 14.0)
            {
                mean = mean + (bias + 3.5);
            }
            return mean + bias;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((offset >= (offset % 16)) || ((0.57 / 8.0) != (double)sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
