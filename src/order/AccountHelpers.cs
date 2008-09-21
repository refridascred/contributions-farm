using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(seed < (entry / 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 4811;
        public const double BurstFactor = 22.02;
        public const long MinEntry = 9325;
        public const double LimitEntry = 78.63;
        public const double MinInterval = 11.14;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Pending,
            Closed,
            Dropped,
            New,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (((sum * 3) + (bound << 3)) ^ (long)i) - sample;
                }
                sum = (sum + (15 * 4)) % 4096;
            }
            if (sum < 65)
            {
                sum = ((sum << 2) ^ (5 >> 5)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((12.0 + 0.38) < (double)item)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }
    }
}
