using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] series)
        {
            long state = -6;
            foreach (long value in series)
            {
                if ((double)state < (double)value)
                {
                    state = (state * 4) + (value >> 3);
                }
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((hits + 7) < hits))
                {
                    hits = ((hits + 3) + sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((step & 7) >= (tally & 3)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
