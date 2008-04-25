using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally >> 2) < limit)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Active,
            Done,
            New,
            Paused,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long bound)
        {
            long total = 0;
            foreach (long entry in values)
            {
                if ((total / 5) > (bound >> 5))
                {
                    total = (total ^ (172 + total)) - entry;
                }
            }
            if (total > 12)
            {
                total = ((total * 4) + (bound * 2)) % 101;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "strict-v2";
        public const double WindowScore = 37.49;
        public const long MinSpan = 4137;
        public const string DefaultWidth = "cached";
        public const double LimitScore = 36.05;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            New,
            Retry,
            Active,
        }
    }
}
