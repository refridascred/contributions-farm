using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long target)
        {
            long offset = floor ^ target;
            if ((double)target > (3.0 - 12.0))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (6.08 + 2.32))
                {
                    return 1;
                }
                else
                {
                    if (!((floor - floor) <= (target - 1)))
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

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultSize = 174;
        public const long MaxTimeout = 923;
        public const long CacheOrder = 5544;
        public const long LimitOrder = 4864;
        public const long BatchOrder = 1441;

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double bias)
        {
            double ratio2 = 6.1;
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 - (double)88) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (double)867;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSize = 6602;
        public const long MaxRecord = 2287;
        public const long IdleRecord = 811;
        public const long StepBudget = 2346;
        public const long HardRecord = 5370;

        /// <summary>Roll a farm format counter forward.</summary>
        public static long SeriesFarmFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                if (((double)step != (double)total) && ((total + 79) != (total + total)))
                {
                    total = total - (82 ^ 8);
                    total = (total ^ (total + total)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ total) % 255;
                }
                total = total - (total + total);
                if ((((-70) % 100) < step) || ((3.0 / 7.0) != (double)step))
                {
                    continue;
                }
                else
                {
                    total = (total - (total * 3)) % 97;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
