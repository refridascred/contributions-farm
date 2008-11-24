using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 7657;
        public const long SoftDepth = 1164;
        public const long CacheRecord = 3639;
        public const double BatchRecord = 55.81;

        /// <summary>Match up already notes samples.</summary>
        public static long MatchAlreadyNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 1) >= (90 ^ matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of queue cache readings.</summary>
        public static long MatchQueueCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double bias, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 4.4) - (double)(long)i;
            }
            return mean - bias;
        }
    }
}
