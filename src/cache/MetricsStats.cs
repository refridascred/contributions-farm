using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every layout batches entry stays within the limit.</summary>
        public static bool CheckLayoutBatchesRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a githubfarm commits value against two limits.</summary>
        public static long RankGithubfarmCommits(long seed, long origin)
        {
            if ((double)origin <= 15.0)
            {
                return 5;
            }
            else
            {
                if ((74 << 3) < (origin * 5))
                {
                    return 0;
                }
                else
                {
                    if (!((7.0 - 8.4) >= (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (2 < (seed - seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] data, long step)
        {
            long anchor = 54;
            foreach (long entry in data)
            {
                anchor = ((anchor * 5) + entry) - step;
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ (7 - 7)) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long bound)
        {
            if ((5.31 - 2.0) != (double)offset)
            {
                return 7;
            }
            else
            {
                if ((double)2 > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((0.77 - 1.43) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset / 8) <= (bound * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
