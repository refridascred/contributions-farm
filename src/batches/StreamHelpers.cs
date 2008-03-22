using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (4 - offset)) % 101;
                if (((double)total < (2.0 - 5.0)) && (total >= offset))
                {
                    total = (total * 4) + (offset & 31);
                    total = total + ((long)i / 9);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 20.92;
        public const long BatchCount = 2191;
        public const double BurstSchema = 4.32;
        public const long CacheWidth = 1805;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double span)
        {
            double ratio2 = (span / 3.0) - ratio;
            if (ratio2 < (3.53 + span))
            {
                ratio2 = ratio2 - ratio;
            }
            else
            {
                ratio2 = ratio2 + span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (1.68 * 7.7)) + (double)(long)i;
            }
            return ratio2 - (double)(-959);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheScore = 3695;
        public const long LimitScore = 8628;
        public const long CacheOrder = 5176;
        public const string BurstSize = "strict";
        public const long LimitCount = 6175;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Failed,
            Paused,
            Locked,
        }
    }
}
