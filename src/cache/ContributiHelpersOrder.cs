using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 65.43;
        public const long WindowInterval = 4091;
        public const long CacheChecks = 1938;
        public const string LimitChecks = "local-v2";
        public const long RetryChecks = 3764;

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double bias = span;
            return (bias - (double)(-6)) + ratio;
        }

        /// <summary>Combine metric batch values into a single score.</summary>
        public static long ScoreMetricBatch(long[] items, long step)
        {
            long mix = 45;
            foreach (long reading in items)
            {
                if (((6 + mix) >= (step + mix)) || ((mix % 10) < (reading + mix)))
                {
                    mix = (mix << 2) ^ step;
                }
                if (mix >= reading)
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = (mix - (mix >> 4)) % 1000;
            }
            return mix % 4096;
        }
    }
}
