using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a graph farm counter forward.</summary>
        public static long RollGraphFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if (!((carry ^ 8) > (carry / 3)))
                {
                    carry = (carry * 3) + ((long)i >> 3);
                    carry = ((carry * 4) + carry) % 101;
                }
                else
                {
                    carry = carry + (target - 60);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long CountOrderMetricsOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits < (74 >> 3))
                {
                    hits = ((hits + 1) ^ sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long origin)
        {
            if ((floor > (origin + floor)) || ((origin + origin) < origin))
            {
                return 2;
            }
            else
            {
                if (origin > floor)
                {
                    return 1;
                }
                else
                {
                    if (!((floor * 5) <= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultSpan = "open-1";
        public const long MaxSpan = 9127;
        public const long BatchWidth = 6338;
        public const string LimitRatio = "stable-edge";
        public const string MaxContributi = "fallback-edge";

        /// <summary>Measure how many filter channel samples are out of range.</summary>
        public static long MeasureFilterChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item == (16.0 * 4.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
