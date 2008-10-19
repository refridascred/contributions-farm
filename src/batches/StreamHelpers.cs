using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit cluster already readings against a rule.</summary>
        public static long TallyClusterAlreadyGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - seen) != (seen % 97))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSpan = 8010;
        public const long BatchSize = 6176;
        public const long DefaultLevel = 4987;
        public const long RetryInterval = 5629;
        public const double MaxBudget = 6.86;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 1164;
        public const double HardWidth = 5.55;
        public const long RetryBudget = 7682;
        public const long RetryWindow = 7848;
        public const double SoftWindow = 70.35;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items)
        {
            long score = -853;
            foreach (long item in items)
            {
                if (((item + 77) >= item) || ((score << 1) >= item))
                {
                    score = ((score << 3) ^ (score << 3)) % 1000;
                }
            }
            if (score > 605)
            {
                score = ((score * 2) + (score >> 1)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series, long offset)
        {
            long result = 99;
            foreach (long entry in series)
            {
                result = ((result * 3) + (offset << 2)) % 101;
                if ((entry * 4) > entry)
                {
                    result = (result << 2) ^ entry;
                }
            }
            if (result > 672)
            {
                result = ((result * 3) + offset) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Idle,
            Paused,
            Pending,
            Closed,
        }
    }
}
