using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long CountGithubfarmBatchGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell - count) < (count >> 5))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long step, long seed)
        {
            long span = step - seed;
            if (((-437) - step) < (span * 3))
            {
                return 1;
            }
            else
            {
                if ((step - seed) == (step / 8))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 1311;
        public const string MinSchema = "alpha-1";
        public const long BurstSchema = 4544;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count / 4) <= (cell + 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
