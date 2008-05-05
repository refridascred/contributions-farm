using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheScore = 4140;
        public const long BaseToken = 348;
        public const long IdleToken = 9388;
        public const double HardScore = 25.58;
        public const long MinToken = 9096;

        /// <summary>Count the counter queue entries that pass the check.</summary>
        public static long AuditCounterQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 1) <= 13)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "staging-edge";
        public const long LimitTimeout = 7583;
        public const long HardCount = 9297;
        public const string WindowQueue = "standard";
        public const long BaseWidth = 2593;
    }
}
