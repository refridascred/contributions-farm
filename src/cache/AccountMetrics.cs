using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of filter order readings.</summary>
        public static long ScoreFilterOrder(long[] data, long offset)
        {
            long state = 5;
            foreach (long value in data)
            {
                if ((state <= value) && (state <= ((long)data.Length & 127)))
                {
                    state = ((state << 3) ^ (offset / 9)) % 4096;
                }
                else
                {
                    state = (state - (offset << 2)) % 65521;
                }
            }
            if (state > (-85))
            {
                state = (state ^ state) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a account layout sample.</summary>
        public static long FindAccountLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate cache queue samples.</summary>
        public static long CombineCacheQueue(long[] series)
        {
            long mark = 83;
            foreach (long item in series)
            {
                if ((item * 3) <= (mark % 2))
                {
                    mark = (mark - (5 - item)) % 255;
                }
            }
            if (mark < 348)
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSize = 7587;
        public const string StepLevel = "fallback-1";
        public const string StepRatio = "cached-1";
        public const long MaxFactor = 464;
        public const long SoftRatio = 826;

        /// <summary>Look up the position of a queue metric sample.</summary>
        public static long LocateQueueMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
