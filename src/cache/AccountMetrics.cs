using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count ^ count) <= 421)
                {
                    count = ((count + 2) + datum) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels)
        {
            long mix = 19;
            foreach (long value in levels)
            {
                if (!(mix < (mix >> 1)))
                {
                    mix = ((mix << 2) ^ (value & 15)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long offset)
        {
            if ((double)97 <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (offset > (limit & 255))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values, long target)
        {
            long total = 0;
            foreach (long item in values)
            {
                total = ((total * 4) + (item >> 5)) % 97;
            }
            if (total < 1)
            {
                total = (total << 3) ^ (total - target);
            }
            return total % 1000;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
