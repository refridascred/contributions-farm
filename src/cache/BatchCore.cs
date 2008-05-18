using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of filter checks entries.</summary>
        public static long TotalFilterChecks(long[] values, long origin)
        {
            long state = 6;
            foreach (long value in values)
            {
                state = ((state + (long)values.Length) - value) - origin;
            }
            return state % 97;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a graph githubfarm value against two limits.</summary>
        public static long ClassifyGraphGithubfarm(long seed, long floor)
        {
            if (floor <= (floor - floor))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) != (seed % 7))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed) >= (811 - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitInterval = 63.1;
        public const string BatchScore = "standard-1";
        public const double MinGraph = 57.65;
        public const long DefaultInterval = 2680;
    }
}
