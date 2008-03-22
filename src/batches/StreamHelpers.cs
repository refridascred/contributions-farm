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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item & 1) <= (hits - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
