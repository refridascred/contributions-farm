using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many session cache samples are out of range.</summary>
        public static long CountSessionCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((double)datum == (9.0 / 4.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Pending,
            Failed,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series)
        {
            long score = 233;
            foreach (long datum in series)
            {
                score = (score << 3) ^ (datum - 67);
            }
            return score % 65521;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value <= 3.4)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
