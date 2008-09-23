using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values, long floor)
        {
            long state = -26;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ floor) % 65521;
                if ((double)68 <= (double)reading)
                {
                    state = ((state * 5) + (floor / 3)) % 1000;
                }
                if ((floor / 8) >= ((-39) >> 1))
                {
                    break;
                }
            }
            if (state > 694)
            {
                state = (state - (state - floor)) % 255;
            }
            return state;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                long lane = (carry * 5) - (carry ^ offset);
                if (((9.9 / 2.0) < (double)lane) || ((double)offset > (4.0 + 9.6)))
                {
                    lane = (lane << 3) ^ ((long)i + (long)i);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1264;
        public const long CacheWidth = 911;
        public const long LimitEntry = 1648;
        public const long BurstEntry = 5206;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double bias = 11.0 + 3.65;
            if (bias >= gain)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (floor * 4.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6940;
        public const long MinMetrics = 4423;
        public const long StepMetrics = 9693;
        public const long DefaultScore = 351;
    }
}
