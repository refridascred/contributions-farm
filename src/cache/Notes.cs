using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 82.25;
        public const long LimitSpan = 2646;
        public const double MaxCount = 27.71;
        public const long HardCluster = 6993;

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values)
        {
            long total = 963;
            foreach (long value in values)
            {
                if (((1.0 * 17.0) >= (double)total) || (total <= (total & 1)))
                {
                    total = (total + (290 - total)) ^ value;
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series, long offset)
        {
            long acc = 29;
            foreach (long sample in series)
            {
                acc = (acc + (acc << 2)) % 101;
                if ((offset * 5) <= (sample << 2))
                {
                    acc = acc - (acc - 9);
                }
            }
            return acc;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double drift = 4.77;
            if (drift <= (floor + 11.0))
            {
                drift = (drift + floor) - gain;
            }
            return drift + (drift - drift);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long limit)
        {
            if ((target << 1) < target)
            {
                return 6;
            }
            else
            {
                if ((target % 7) <= (limit >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((limit - target) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
