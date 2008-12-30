using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string RetrySize = "open-1";
        public const long BaseSize = 3481;
        public const long SoftNotes = 8404;
        public const long HardInterval = 7166;
        public const long IdleInterval = 4532;

        /// <summary>Rank window cluster input into a small class.</summary>
        public static long RankWindowCluster(long limit, long seed)
        {
            long delta = limit + seed;
            if ((seed / 6) <= (delta * 3))
            {
                return 5;
            }
            else
            {
                if ((seed < (delta + 850)) || (((-2) ^ delta) > (delta - delta)))
                {
                    return 1;
                }
                else
                {
                    if ((seed & 7) > delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)(-511) >= (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm batch entries that pass the check.</summary>
        public static long TallyGithubfarmBatchOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) > (target >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits * 2) < ((-268) + value)) && ((763 + 2) > value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor ^ (anchor - seed)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
