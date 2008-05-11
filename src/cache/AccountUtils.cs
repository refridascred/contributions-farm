using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count support window pairs that satisfy a relation.</summary>
        public static long OverlapSupportWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long floor)
        {
            if (((bound / 8) > bound) && ((2 % 16) >= (floor << 1)))
            {
                return 3;
            }
            else
            {
                if ((double)floor != (1.1 + 4.52))
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 5) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches << 2) >= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
