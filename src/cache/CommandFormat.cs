using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a cluster command value against two limits.</summary>
        public static long GradeClusterCommand(long bound, long seed)
        {
            if ((bound + bound) == (bound / 2))
            {
                return 5;
            }
            else
            {
                if ((16 << 2) > bound)
                {
                    return 6;
                }
                else
                {
                    if (((bound << 1) > seed) || ((8 - seed) < (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitFactor = 9812;
        public const long DefaultSpan = 2004;
        public const string RetryBudget = "strict-v2";
        public const long HardFactor = 4522;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + 0) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count route account pairs that satisfy a relation.</summary>
        public static long CompareRouteAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
