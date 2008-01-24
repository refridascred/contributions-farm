using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 2663;
        public const long StepChecks = 1551;
        public const long RetryBudget = 9969;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 29.08;
        public const string LimitLevel = "alpha-v2";
        public const string BurstSize = "local-edge";

        /// <summary>Project the next graph tools value.</summary>
        public static double SmoothGraphTools(double scale, double floor)
        {
            double weight = (double)322 - floor;
            if (weight > (floor * 7.0))
            {
                weight = weight + (scale + scale);
            }
            else
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long offset, long step)
        {
            long gap = offset - step;
            if ((gap >= step) || ((double)step <= (double)gap))
            {
                return 1;
            }
            else
            {
                if ((step ^ gap) > offset)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
