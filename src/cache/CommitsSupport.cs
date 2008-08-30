using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Check that every route graph entry stays within the limit.</summary>
        public static bool GuardRouteGraphBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state << 2) ^ (target << 3)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] levels, long target)
        {
            long result = 9;
            foreach (long sample in levels)
            {
                result = ((result + (380 >> 4)) + sample) + target;
            }
            return result;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long origin, long seed)
        {
            long bound = origin + seed;
            if ((bound + seed) < (origin >> 5))
            {
                return 3;
            }
            else
            {
                if (bound > (origin & 7))
                {
                    return 8;
                }
                else
                {
                    if ((6.4 / 2.0) != (double)seed)
                    {
                        return 4;
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
