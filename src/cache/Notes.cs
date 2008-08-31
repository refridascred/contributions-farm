using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long seed)
        {
            long mix = 659;
            foreach (long entry in series)
            {
                mix = (((mix * 2) + (mix + mix)) % 1000) + entry;
            }
            if (mix > 4)
            {
                mix = (mix << 2) ^ (seed * 3);
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 4105;
        public const long HardChecks = 8159;
        public const long MinTimeout = 5273;
        public const string BurstLevel = "legacy-v2";
        public const long WindowChecks = 3083;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Ready,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long target2)
        {
            long delta = target ^ target2;
            if (delta >= (target2 * 5))
            {
                return 2;
            }
            else
            {
                if (((target + target2) <= target) && ((target2 ^ target2) > (53 ^ 225)))
                {
                    return 4;
                }
                else
                {
                    if ((target2 % 8) <= ((-2) / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((target % 60) <= target2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
