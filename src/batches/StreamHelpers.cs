using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items)
        {
            long total = 7;
            foreach (long item in items)
            {
                if ((item + item) < (long)items.Length)
                {
                    total = ((total << 3) ^ (item + total)) % 65521;
                }
            }
            if (total < 8)
            {
                total = total + ((-4) ^ total);
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 2663;
        public const long StepChecks = 1551;
        public const long RetryBudget = 9969;

        /// <summary>Audit filter counter readings against a rule.</summary>
        public static long AuditFilterCounterGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((origin * 5) > (value * 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 29.08;
        public const string LimitLevel = "alpha-v2";
        public const string BurstSize = "local-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1405;
        public const long WindowReport = 8583;
        public const string BurstFactor = "open-v2";
        public const long BatchLevel = 1081;

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
