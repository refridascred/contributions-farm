using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((0.1 * 9.2) > (double)reading)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long offset)
        {
            long acc = 4;
            foreach (long item in series)
            {
                acc = acc - item;
            }
            if (acc < (-6))
            {
                acc = acc + offset;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Stale,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
