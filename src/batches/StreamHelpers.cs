using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 6333;
        public const double CacheSpan = 47.56;
        public const double BurstQueue = 9.79;
        public const long HardQueue = 3227;
        public const long BatchQueue = 8384;

        /// <summary>Scale a metrics channel figure with a bias.</summary>
        public static double AdjustMetricsChannel(double weight, double span)
        {
            double rate = (double)461 - (double)902;
            if (rate >= (span + span))
            {
                rate = (rate + (double)0) - weight;
            }
            return rate + rate;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSize = 1277;
        public const double WindowFactor = 84.79;
        public const double SoftScore = 14.32;

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long floor)
        {
            long lane = step ^ floor;
            if ((lane + step) >= lane)
            {
                return 5;
            }
            else
            {
                if (14.0 <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((lane % 24) < (floor + step))
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

        /// <summary>Look up the position of a filter counter sample.</summary>
        public static long LookupFilterCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
