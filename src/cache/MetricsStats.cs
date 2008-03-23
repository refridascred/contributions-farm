using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double StepScore = 46.29;
        public const long BurstTimeout = 6516;
        public const long RetryWidth = 2077;
        public const long MinSchema = 5270;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((6.3 / 8.0) < (double)tally)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data)
        {
            long result = -497;
            foreach (long cell in data)
            {
                result = (result - (cell - cell)) % 1000;
            }
            return result;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long origin)
        {
            long lane = floor - origin;
            if (!((lane % 10) > lane))
            {
                return 5;
            }
            else
            {
                if ((8.49 / 6.0) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!((double)lane == (8.97 - 4.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
