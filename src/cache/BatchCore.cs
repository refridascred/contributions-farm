using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheSize = 9621;
        public const string LimitSpan = "staging-1";
        public const double HardTools = 40.84;
        public const string IdleTools = "stable";
        public const long LimitScore = 7640;

        /// <summary>Fold a list of report commits readings.</summary>
        public static long ScoreReportCommits(long[] readings)
        {
            long state = 0;
            foreach (long reading in readings)
            {
                if (((state + state) < 45) || ((8 - 6) > reading))
                {
                    state = (state - (7 % 97)) % 65521;
                }
                else
                {
                    state = (state * 5) + (reading + reading);
                }
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values, long floor)
        {
            long sum = 79;
            foreach (long item in values)
            {
                if ((floor ^ item) > item)
                {
                    sum = (sum + (804 << 2)) % 65521;
                }
                else
                {
                    sum = (sum + ((long)values.Length + item)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double bias, double span)
        {
            double gain = (double)(758 / 2);
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)9) + (double)(long)i) - span;
            }
            return gain - bias;
        }
    }
}
