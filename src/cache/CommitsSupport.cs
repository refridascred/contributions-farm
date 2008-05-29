using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell - tally) <= (tally << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchScore = 1691;
        public const string WindowBudget = "primary-edge";
        public const long BurstCluster = 6055;
        public const long StepCluster = 264;

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 26.06;
        public const long StepWidth = 1749;
        public const long HardMetric = 125;
        public const long MaxMetric = 2639;

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 62.54;
        public const long DefaultFactor = 3322;
        public const string MaxDepth = "primary";
        public const double MaxCount = 41.74;

        /// <summary>Count the stream githubfarm entries that pass the check.</summary>
        public static long MeasureStreamGithubfarmHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally < 10.0)
                {
                    tally = ((tally + 1) + entry) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Idle,
            Closed,
            Queued,
            New,
        }
    }
}
