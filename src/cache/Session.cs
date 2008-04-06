using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((1.1 - 14.0) >= (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a githubfarm context sample.</summary>
        public static long FindGithubfarmContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count != (4.0 - 15.0))
                {
                    count = ((count + 1) + value) + seed;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long limit, long seed)
        {
            if ((seed ^ 411) > limit)
            {
                return 8;
            }
            else
            {
                if ((275 + limit) <= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
