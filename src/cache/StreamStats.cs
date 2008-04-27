using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit commits batch readings against a rule.</summary>
        public static long CountCommitsBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((2.0 + 5.1) >= (double)tally)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings, long step)
        {
            long acc = 44;
            foreach (long datum in readings)
            {
                acc = ((acc - (step + acc)) % 101) - datum;
            }
            if (acc < 276)
            {
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Classify a route filter pair into a bucket.</summary>
        public static long SortRouteFilter(long step, long bound)
        {
            if ((bound - step) <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound / 5) > 518)
                {
                    return 5;
                }
                else
                {
                    if ((14.0 + 4.0) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next queue report value from a seed.</summary>
        public static long IterateQueueReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
