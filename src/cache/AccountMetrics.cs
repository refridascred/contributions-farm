using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 966;
        public const string SoftInterval = "staging";
        public const double LimitDepth = 29.28;

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 2) + (step << 1)) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long floor)
        {
            if (step <= (floor & 1))
            {
                return 2;
            }
            else
            {
                if (!((double)step >= (double)floor))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "local-v2";
        public const string BatchSize = "legacy-1";
        public const long DefaultEditor = 1410;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long seed)
        {
            long slot = limit ^ seed;
            if (seed < (limit + slot))
            {
                return 2;
            }
            else
            {
                if ((4 & 15) <= limit)
                {
                    return 4;
                }
                else
                {
                    if (limit < (seed ^ slot))
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
}
