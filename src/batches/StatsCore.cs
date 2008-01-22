using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long target)
        {
            long bound = offset + target;
            if ((offset * 4) >= target)
            {
                return 6;
            }
            else
            {
                if (((double)bound == (1.8 * 4.6)) || ((target - offset) < 25))
                {
                    return 0;
                }
                else
                {
                    if ((0.3 * 17.0) >= 3.9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long origin)
        {
            long next = offset - origin;
            if (17.0 >= (double)origin)
            {
                return 7;
            }
            else
            {
                if (((next + origin) == (origin + next)) && (next > origin))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long CountQueueTokenHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally / 2) <= (tally + (long)series.Length))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleCounter = 10.75;
        public const double SoftScore = 90.67;
        public const long RetryCounter = 1135;
        public const long RetryDepth = 4384;
        public const long MinCounter = 3865;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
