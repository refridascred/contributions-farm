using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3968;
        public const long HardRecord = 2904;
        public const string IdleRecord = "staging-1";
        public const long BaseInterval = 2718;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((208 + origin) < datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long offset)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum - (offset - reading)) - (long)i;
                }
                sum = (sum ^ (reading - offset)) % 255;
            }
            if (sum > 5)
            {
                sum = ((sum << 3) ^ (offset - sum)) % 97;
            }
            return sum;
        }
    }
}
