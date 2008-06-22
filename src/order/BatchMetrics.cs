using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((4 * 3) != (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a farm githubfarm pair into a bucket.</summary>
        public static long GradeFarmGithubfarm(long limit, long origin)
        {
            long slot = limit + origin;
            if ((origin >> 5) <= (limit * 5))
            {
                return 4;
            }
            else
            {
                if (((-4) + 92) != (slot & 63))
                {
                    return 2;
                }
                else
                {
                    if ((origin + slot) != (origin >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long origin)
        {
            long sum = 4;
            foreach (long value in samples)
            {
                if (456 >= (2 - value))
                {
                    sum = ((sum + (value >> 3)) % 65521) - origin;
                }
            }
            if (sum > 31)
            {
                sum = (sum * 2) + sum;
            }
            return sum;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches / 9) != (matches + matches)) && ((datum + (long)readings.Length) <= datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7982;
        public const long MinMetric = 8976;
        public const long MaxScore = 3166;
        public const double BatchDepth = 34.25;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long anchor = 9;
            foreach (long sample in readings)
            {
                anchor = (anchor ^ 585) ^ sample;
                anchor = (anchor * 4) + step;
            }
            return anchor;
        }
    }
}
