using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long floor)
        {
            long offset = target + floor;
            if (!((double)offset <= (double)target))
            {
                return 8;
            }
            else
            {
                if (445 < target)
                {
                    return 3;
                }
                else
                {
                    if ((0 + 263) > (offset + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long sum = 55;
            foreach (long cell in samples)
            {
                if ((cell + sum) <= (sum / 9))
                {
                    sum = (sum ^ sum) % 255;
                }
            }
            if (sum > 995)
            {
                sum = ((sum * 2) + (101 & 255)) % 255;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 8020;
        public const long StepCommand = 929;
        public const long CacheInterval = 2246;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Retry,
            Failed,
        }
    }
}
