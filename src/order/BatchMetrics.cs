using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series, long target)
        {
            long total = -993;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (total << 3) ^ ((long)i % 8);
                }
                if (reading < (total / 6))
                {
                    total = (total << 3) ^ total;
                }
            }
            if (total > 8)
            {
                total = total - target;
            }
            return total;
        }

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

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "open";
        public const string BurstCommand = "fallback-v2";
        public const long BaseCommand = 4498;

        /// <summary>Match up window metrics samples.</summary>
        public static long OverlapWindowMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
