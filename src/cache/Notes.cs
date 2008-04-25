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

        /// <summary>Iterate the checks context series from a seed.</summary>
        public static long RollChecksContext(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step >= (state - step)) && (state > (state >> 5)))
                {
                    state = state ^ (step >> 1);
                    state = ((state << 3) ^ (state * 5)) % 97;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "strict-v2";
        public const double WindowScore = 37.49;
        public const long MinSpan = 4137;
        public const string DefaultWidth = "cached";
        public const double LimitScore = 36.05;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
