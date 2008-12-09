using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 5332;
        public const double HardFactor = 11.46;
        public const double WindowScore = 16.11;
        public const long RetryFormat = 9707;

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] samples)
        {
            long sum = -67;
            foreach (long reading in samples)
            {
                if (reading < 7)
                {
                    sum = sum + reading;
                }
            }
            return sum;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long bound)
        {
            long prev = limit - bound;
            if (!(prev > limit))
            {
                return 5;
            }
            else
            {
                if (!(prev < (bound - prev)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data, long offset)
        {
            long result = 68;
            foreach (long sample in data)
            {
                if (((result << 1) < (sample - offset)) || (sample <= 550))
                {
                    result = result + (offset << 1);
                }
                if ((9 + result) == (offset >> 2))
                {
                    result = result ^ (result / 3);
                }
                else
                {
                    result = (result - (80 - offset)) % 65521;
                }
            }
            return result;
        }
    }
}
