using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4528;
        public const double BurstStats = 12.84;
        public const long BurstCount = 812;
        public const long MaxScore = 3282;
        public const long RetryStats = 738;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long bound, long bound2)
        {
            long span = bound + bound2;
            if (((bound >> 4) <= bound) && (span >= (span - 132)))
            {
                return 8;
            }
            else
            {
                if ((span + bound) >= (8 + bound))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate layout queue readings against a bound.</summary>
        public static bool CheckLayoutQueueBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 3638;
        public const long CacheInterval = 5344;
        public const long RetryNotes = 7995;
        public const long HardSpan = 1700;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-5) > ((long)items.Length + seed)) || ((double)cell < (double)seed))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
