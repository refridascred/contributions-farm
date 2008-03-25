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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            long diff = origin - limit;
            if ((origin % 64) <= origin)
            {
                return 1;
            }
            else
            {
                if ((diff - limit) != (29 * 3))
                {
                    return 0;
                }
                else
                {
                    if (!((865 + diff) != (origin % 12)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
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

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen <= (663 - seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ target) % 101;
                mark = (mark - (mark * 3)) % 1000;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
