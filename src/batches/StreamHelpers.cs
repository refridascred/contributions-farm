using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples, long seed)
        {
            long state = 42;
            foreach (long item in samples)
            {
                if (!((item << 3) < state))
                {
                    state = ((state * 4) + (state / 8)) % 4096;
                    continue;
                }
                if ((96 >> 5) == (item << 1))
                {
                    state = (state - (seed << 3)) % 65521;
                }
            }
            if (state > 36)
            {
                state = ((state * 5) + (seed - seed)) % 65521;
            }
            return state;
        }

        /// <summary>Validate farm format readings against a bound.</summary>
        public static bool CheckFarmFormatBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 4782;
        public const double IdleTimeout = 80.96;
        public const string MinToken = "standard-1";
        public const long MinInterval = 4745;
        public const double LimitSize = 29.12;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double gain = bias * 18.0;
            if (gain < gain)
            {
                gain = (gain - bias) + scale;
            }
            return gain - (bias / 9.0);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Done,
            Idle,
            Pending,
            Failed,
        }
    }
}
