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

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "standard-v2";
        public const string BaseAlready = "stable";
        public const long BurstAlready = 8261;

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
