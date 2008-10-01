using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9278;
        public const double MinRatio = 60.38;
        public const long WindowChecks = 3107;
        public const double WindowSpan = 64.36;

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            New,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings)
        {
            long state = 150;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 3) + reading) + (long)i;
                }
                if ((state / 4) != (0 ^ state))
                {
                    state = (state ^ (reading ^ state)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long origin, long offset)
        {
            long edge = origin - offset;
            if ((offset >> 4) != (64 - offset))
            {
                return 7;
            }
            else
            {
                if ((22 * 4) < (edge / 7))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
