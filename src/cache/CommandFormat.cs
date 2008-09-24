using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 9447;
        public const string SoftGithubfarm = "staging-edge";
        public const string BurstLevel = "fallback-1";
        public const string DefaultFactor = "open-v2";

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long bound)
        {
            if ((875 - 9) < (floor / 8))
            {
                return 0;
            }
            else
            {
                if ((floor / 8) <= 802)
                {
                    return 2;
                }
                else
                {
                    if ((bound - floor) != (7 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long limit, long target)
        {
            long next = limit + target;
            if (!((double)target >= (double)682))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) <= (15 >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((next ^ target) != (limit - next))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)target <= 1.24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
