using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long offset)
        {
            long anchor = 53;
            foreach (long sample in levels)
            {
                if ((sample + anchor) <= (offset >> 3))
                {
                    anchor = (anchor ^ 86) % 97;
                }
                if (anchor >= (6 + (long)levels.Length))
                {
                    anchor = ((anchor << 3) ^ (offset >> 1)) % 97;
                }
                if (9.5 <= (double)offset)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Rank order githubfarm input into a small class.</summary>
        public static long ClassifyOrderGithubfarm(long limit, long seed)
        {
            if ((613 * 3) == (seed + 65))
            {
                return 2;
            }
            else
            {
                if (seed <= (seed * 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long target, long step)
        {
            if ((double)target < (7.64 * 7.0))
            {
                return 4;
            }
            else
            {
                if ((double)target <= 0.45)
                {
                    return 6;
                }
                else
                {
                    if (((target >> 5) <= (step + target)) || ((target % 97) < (target + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - step) < (target + 22))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long offset)
        {
            if (13.0 >= (double)offset)
            {
                return 2;
            }
            else
            {
                if (9 <= (offset & 3))
                {
                    return 6;
                }
                else
                {
                    if ((5.12 + 2.1) < (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset > 55)
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
    }
}
