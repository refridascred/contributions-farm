using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long step, long bound)
        {
            if ((6.87 / 3.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((2.2 * 7.88) >= (6.7 - 2.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a report commits pair into a bucket.</summary>
        public static long RankReportCommits(long offset, long limit)
        {
            long bound = offset ^ limit;
            if (19 > (limit ^ bound))
            {
                return 3;
            }
            else
            {
                if ((double)offset < 6.0)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (20.0 + 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((306 + bound) < (offset / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Done,
            Active,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits - hits) > reading) || ((1.96 * 18.0) < (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
