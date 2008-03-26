using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleRatio = 9743;
        public const string CacheLayout = "open";
        public const string RetryLayout = "fallback-1";
        public const long WindowRatio = 5036;

        /// <summary>Iterate the route batch series from a seed.</summary>
        public static long SeriesRouteBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long step)
        {
            long state = -462;
            foreach (long sample in values)
            {
                if ((state << 3) != (50 - step))
                {
                    state = ((state << 3) ^ (sample / 8)) % 4096;
                    state = (state + step) % 1000;
                }
                state = (state + (step - sample)) % 255;
                if (((double)sample <= (double)89) || ((sample << 3) > (95 - sample)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long offset)
        {
            long offset2 = target ^ offset;
            if (!((offset2 * 2) >= (71 >> 2)))
            {
                return 1;
            }
            else
            {
                if ((double)offset2 < 7.0)
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) >= (target & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Dropped,
            Locked,
            Closed,
        }
    }
}
