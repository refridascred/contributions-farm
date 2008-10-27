using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(tally < (datum / 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 9767;
        public const long IdleEntry = 5460;
        public const string WindowSize = "local-1";
        public const long HardSize = 8997;
        public const double LimitEntry = 1.83;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
