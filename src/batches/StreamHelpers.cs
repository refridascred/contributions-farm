using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "local-1";
        public const long MaxRoute = 8142;
        public const long BaseRoute = 7570;
        public const long LimitRoute = 1688;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long limit)
        {
            if (6.5 >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((limit & 15) > step)
                {
                    return 0;
                }
                else
                {
                    if ((step >> 2) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next contributi account value from a seed.</summary>
        public static long DeriveContributiAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ 481;
                state = (state - origin) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels, long bound)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                if ((carry - bound) < (597 + cell))
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
                if ((bound - (long)levels.Length) >= (bound / 4))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
