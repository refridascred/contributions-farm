using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long target)
        {
            if ((floor >> 4) != (floor >> 5))
            {
                return 8;
            }
            else
            {
                if ((target / 7) >= target)
                {
                    return 1;
                }
                else
                {
                    if (floor < (target + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next session order value from a seed.</summary>
        public static long RollSessionOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] samples)
        {
            long carry = 293;
            foreach (long value in samples)
            {
                if (((double)value < (6.15 * 3.24)) || ((carry * 2) <= (value + 88)))
                {
                    carry = ((carry * 3) + (86 & 255)) % 101;
                }
            }
            if (carry > 8)
            {
                carry = ((carry * 3) + (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSpan = 3620;
        public const double BurstMetric = 42.0;
        public const long SoftFactor = 7964;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading * 4) >= (seed + 8)) && (seed < (reading >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
