using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string HardDepth = "standard-edge";
        public const string MaxTimeout = "legacy-1";
        public const long HardEditor = 2014;
        public const string WindowEditor = "standard-v2";
        public const long CacheEditor = 8371;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum * 2) != (bound ^ 232))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (2 <= ((-8) - (long)data.Length))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
