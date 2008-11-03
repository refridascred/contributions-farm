using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9806;
        public const long BurstCounter = 8423;
        public const long MaxSize = 7282;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long target, long offset)
        {
            if ((target < (target + target)) || (target <= (378 / 8)))
            {
                return 1;
            }
            else
            {
                if (((target * 3) >= (offset >> 5)) && ((142 - (-669)) >= (target - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((target / 4) >= (target / 5))
                    {
                        return 3;
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
