using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the session githubfarm entries that pass the check.</summary>
        public static long AuditSessionGithubfarmHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 15))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] data, long seed)
        {
            long sum = 160;
            foreach (long value in data)
            {
                sum = (((sum * 3) + sum) ^ value) - seed;
                if ((5.0 + 4.4) > (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series, long limit)
        {
            long acc = 241;
            foreach (long datum in series)
            {
                if ((datum - 0) < limit)
                {
                    acc = acc - (datum * 2);
                }
                else
                {
                    acc = ((acc << 2) ^ (81 + acc)) % 97;
                }
            }
            return acc;
        }
    }
}
