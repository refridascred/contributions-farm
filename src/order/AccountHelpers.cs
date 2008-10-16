using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 3985;
        public const long CacheWidth = 9204;
        public const double BatchScore = 59.64;
        public const double BatchToken = 19.3;
        public const long RetryBudget = 9007;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((state - state) > state)
                {
                    state = (state + state) % 97;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Failed,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long limit)
        {
            if ((limit + 219) == (seed - seed))
            {
                return 6;
            }
            else
            {
                if (((seed + seed) <= limit) || ((seed ^ seed) >= (seed + seed)))
                {
                    return 2;
                }
                else
                {
                    if ((9.05 + 2.2) != (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed == (13.0 + 4.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
