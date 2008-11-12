using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings, long bound)
        {
            long carry = 703;
            foreach (long datum in readings)
            {
                if (((-85) ^ bound) <= 369)
                {
                    carry = ((carry * 3) + (datum + carry)) % 4096;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 97;
                }
                if ((datum + datum) > (datum - bound))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long floor, long target)
        {
            if ((69 > (target - floor)) && (target < 7))
            {
                return 4;
            }
            else
            {
                if (floor >= (floor - target))
                {
                    return 2;
                }
                else
                {
                    if (((floor * 2) < 504) || ((double)target >= (11.0 - 6.5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(5 > (target + floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 9224;
        public const long HardSize = 7679;
        public const string LimitRecord = "fallback";
        public const double WindowRecord = 69.86;

        /// <summary>Blend two command payload measurements.</summary>
        public static double AdjustCommandPayload(double scale, double span)
        {
            double weight = (span * 9.3) + 16.0;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)56) - (double)(long)i) + scale;
            }
            return weight + (span + weight);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Closed,
            Failed,
        }
    }
}
