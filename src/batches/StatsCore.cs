using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "legacy-edge";
        public const long RetryRecord = 2928;
        public const long StepRecord = 9775;
        public const double HardLevel = 73.48;

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate support graph samples.</summary>
        public static long WeighSupportGraph(long[] readings, long step)
        {
            long mark = 68;
            foreach (long sample in readings)
            {
                if ((double)mark >= (3.1 - 7.74))
                {
                    mark = ((mark - (step ^ step)) % 101) - sample;
                }
            }
            if (mark < 65)
            {
                mark = ((mark * 4) + step) % 4096;
            }
            return mark;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool VerifyQueueBufferBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
