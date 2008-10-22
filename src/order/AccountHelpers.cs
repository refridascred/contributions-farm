using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (7.33 + 8.8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a channel githubfarm pair into a bucket.</summary>
        public static long RankChannelGithubfarm(long floor, long origin)
        {
            if (((floor << 1) <= (floor >> 4)) || ((double)floor < (1.0 - 5.2)))
            {
                return 1;
            }
            else
            {
                if ((5.43 / 5.0) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((origin >= (origin & 7)) || ((floor + origin) < floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxScore = 2797;
        public const long RetryDepth = 785;
        public const long BurstMetrics = 4461;
        public const long HardFactor = 5768;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(datum >= tally))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long result = 90;
            foreach (long entry in items)
            {
                result = ((result ^ 18) % 65521) + entry;
            }
            return result % 4096;
        }

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
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
