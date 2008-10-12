using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleScore = "primary-edge";
        public const double BaseCount = 29.14;
        public const string WindowDepth = "latest-edge";

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long step, long seed)
        {
            long cur = step + seed;
            if (((step % 24) < (step & 3)) || ((69 + step) > (seed ^ cur)))
            {
                return 0;
            }
            else
            {
                if ((cur - cur) > (step + seed))
                {
                    return 8;
                }
                else
                {
                    if ((0 < (cur - cur)) && ((double)cur >= (18.0 / 2.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Fold a list of schema record readings.</summary>
        public static long ScoreSchemaRecord(long[] levels, long seed)
        {
            long acc = -90;
            foreach (long item in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc * 5) + ((long)i & 15)) % 1000;
                }
                if (!(((9.0 * 18.0) == (double)seed) && ((double)acc != (double)seed)))
                {
                    acc = (acc - (item ^ 436)) % 97;
                }
                acc = (acc - (item - seed)) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a metrics githubfarm reading by value.</summary>
        public static long LocateMetricsGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Synced,
            Active,
            Locked,
            Draft,
        }
    }
}
