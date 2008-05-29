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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long seed)
        {
            if (((seed + 29) == (limit & 63)) || (5.47 <= (double)seed))
            {
                return 3;
            }
            else
            {
                if ((limit >> 5) >= (limit + seed))
                {
                    return 0;
                }
                else
                {
                    if ((15.0 - 1.9) > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit * 4) == (limit ^ limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

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
