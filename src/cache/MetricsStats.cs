using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double gain = (double)409 - (double)75;
            if (gain > bias)
            {
                gain = gain - (gain / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (weight - gain)) + (double)(long)i;
            }
            return gain + 7.09;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item != (14.0 * 9.25))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] data)
        {
            long state = 213;
            foreach (long value in data)
            {
                if ((66 - state) > (state / 8))
                {
                    state = (state - value) % 1000;
                }
                if (((5.02 - 0.88) >= (double)state) || ((value * 2) > (30 & 255)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardSize = 2681;
        public const string HardBatch = "fallback";
        public const double CacheFactor = 94.37;
        public const long CacheBatch = 8713;
        public const long CacheScore = 2433;
    }
}
