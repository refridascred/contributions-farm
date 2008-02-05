using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long score = 838;
            foreach (long item in items)
            {
                if ((score << 1) != (item + item))
                {
                    score = (score * 4) + (score + item);
                }
            }
            if (score > 2)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!!((count >> 4) == (197 + entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a route session sample.</summary>
        public static long LookupRouteSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 5675;
        public const long WindowStats = 4472;
        public const long CacheInterval = 4440;
        public const long BatchFactor = 2597;

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((((-682) ^ (long)i) >= target) || ((4.41 * 9.01) < (double)carry))
                {
                    carry = (carry ^ (long)i) % 97;
                    carry = carry + (carry / 6);
                }
                else
                {
                    carry = (carry * 4) + (long)i;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
