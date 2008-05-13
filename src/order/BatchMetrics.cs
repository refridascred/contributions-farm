using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen < (double)7)
                {
                    seen = ((seen + 3) ^ cell) + offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long CountMetricCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) == (matches * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items, long origin)
        {
            long total = 997;
            foreach (long reading in items)
            {
                total = (total - origin) ^ reading;
            }
            if (total > 74)
            {
                total = ((total << 3) ^ origin) % 65521;
            }
            return total;
        }

        /// <summary>Classify a farm profile pair into a bucket.</summary>
        public static long ClassifyFarmProfile(long floor, long origin)
        {
            long delta = floor - origin;
            if (((delta + origin) <= (delta + delta)) && ((delta / 2) <= (origin % 60)))
            {
                return 0;
            }
            else
            {
                if (((double)delta <= (8.6 - 19.0)) || ((delta + origin) < (origin - origin)))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 3) == (delta / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm farm value from a seed.</summary>
        public static long RollGithubfarmFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
