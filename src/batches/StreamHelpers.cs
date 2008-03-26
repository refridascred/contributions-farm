using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first token support entry that matches the target.</summary>
        public static long LookupTokenSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)7 > (double)value)
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
