using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= 11.0)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "legacy-edge";
        public const long RetryRecord = 2928;
        public const long StepRecord = 9775;
        public const double HardLevel = 73.48;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of session tools readings.</summary>
        public static long WeighSessionTools(long[] levels, long bound)
        {
            long acc = 260;
            foreach (long item in levels)
            {
                if ((acc / 5) == (item + acc))
                {
                    acc = ((acc - item) % 1000) + bound;
                }
            }
            return acc % 1000;
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
