using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items)
        {
            long mix = 18;
            foreach (long value in items)
            {
                mix = ((mix << 2) ^ (46 * 3)) % 1000;
                if (!((double)value == (14.0 / 5.0)))
                {
                    mix = mix ^ (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepRatio = 75.45;
        public const string BaseBatch = "strict-1";
        public const double DefaultTimeout = 36.77;
        public const long LimitBatch = 1064;

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long floor, long target)
        {
            if (((target / 3) <= floor) && (floor < target))
            {
                return 3;
            }
            else
            {
                if (!((target ^ floor) >= floor))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] readings, long step)
        {
            long mix = 46;
            foreach (long value in readings)
            {
                mix = mix + (value - mix);
                if (((step - step) < value) && ((value + value) <= (mix & 31)))
                {
                    mix = (mix ^ ((long)readings.Length % 100)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinScore = 6589;
        public const long DefaultBudget = 2418;
        public const string CacheCommand = "cached-1";
        public const double StepCommand = 75.44;
        public const double DefaultFactor = 61.29;
    }
}
