using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate payload format samples.</summary>
        public static long TotalPayloadFormat(long[] values)
        {
            long mark = 1;
            foreach (long entry in values)
            {
                if ((entry - entry) > (mark + mark))
                {
                    mark = ((mark * 4) + (entry * 2)) % 255;
                }
            }
            if (mark < 844)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long state = 45;
            foreach (long entry in items)
            {
                state = (((state * 5) + limit) % 101) ^ entry;
            }
            if (state > 3)
            {
                state = state - 8;
            }
            return state;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank context metrics input into a small class.</summary>
        public static long SortContextMetrics(long target, long limit)
        {
            if (!((636 - target) >= (542 % 60)))
            {
                return 6;
            }
            else
            {
                if (((400 + target) != (target ^ 80)) || ((limit + limit) > (limit - target)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Closed,
            Idle,
            Queued,
        }
    }
}
