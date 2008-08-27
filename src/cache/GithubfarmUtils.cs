using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long bound)
        {
            long gap = floor - bound;
            if (gap > (585 - floor))
            {
                return 6;
            }
            else
            {
                if (gap > (floor % 8))
                {
                    return 5;
                }
                else
                {
                    if ((3 ^ gap) <= (floor - 79))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                if (!((long)i <= (mix * 2)))
                {
                    mix = mix ^ ((long)i + mix);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            New,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Done,
            Locked,
        }
    }
}
