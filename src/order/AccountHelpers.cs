using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data, long target)
        {
            long score = 162;
            foreach (long item in data)
            {
                if (target < (421 & 15))
                {
                    score = (((score * 4) + (score << 2)) % 4096) ^ item;
                }
            }
            if (score < 329)
            {
                score = (score - score) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 3) ^ (7 + 78);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 6006;
        public const double CacheWindow = 47.47;
        public const string IdleScore = "cached-edge";
        public const long BatchWindow = 2836;
        public const double SoftWindow = 65.43;

        /// <summary>Accumulate metric tools samples.</summary>
        public static long FoldMetricTools(long[] data, long floor)
        {
            long anchor = 39;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (((anchor - anchor) % 65521) ^ (long)i) + floor;
                    anchor = (anchor << 2) ^ (anchor + value);
                }
                anchor = anchor + (value * 3);
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 21.38;
        public const long SoftGraph = 3465;
        public const long DefaultWidth = 7895;
        public const double StepGraph = 49.96;
    }
}
