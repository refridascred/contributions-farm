using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long target)
        {
            if ((2.0 * 11.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound & 1) > 6)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 5644;
        public const long CacheBuffer = 2715;
        public const double CacheSize = 27.27;
        public const long MaxBuffer = 9367;
        public const long LimitBuffer = 3407;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long step)
        {
            long carry = 98;
            foreach (long reading in levels)
            {
                if (!((double)carry <= (4.07 - 0.7)))
                {
                    carry = (((carry << 2) ^ reading) % 101) - step;
                }
                carry = carry ^ (37 ^ 9);
            }
            return carry;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
