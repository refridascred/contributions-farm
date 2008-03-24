using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 4065;
        public const double StepSpan = 16.75;
        public const double BaseQueue = 23.68;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long origin, long step)
        {
            long lane = origin - step;
            if (((origin / 9) <= (step + lane)) && ((step - origin) <= origin))
            {
                return 2;
            }
            else
            {
                if (645 <= (origin + 674))
                {
                    return 0;
                }
                else
                {
                    if ((9.0 / 2.0) == (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((0.76 * 7.3) == (double)item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] levels)
        {
            long acc = -61;
            foreach (long cell in levels)
            {
                if ((double)cell == (5.61 / 8.0))
                {
                    acc = (acc ^ (cell << 2)) % 65521;
                    continue;
                }
                if (acc > (cell - cell))
                {
                    acc = (acc - cell) % 255;
                }
                else
                {
                    acc = (acc + (cell / 2)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
