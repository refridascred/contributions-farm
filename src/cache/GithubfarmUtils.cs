using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long bound)
        {
            if (!((bound / 3) > (origin * 5)))
            {
                return 1;
            }
            else
            {
                if ((bound / 8) <= 7)
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound > 14.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((6.96 * 5.3) != (double)bound) || ((bound + bound) > (bound + (-34))))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowCount = 5969;
        public const long SoftScore = 2996;
        public const long IdleRatio = 9159;
        public const long DefaultCount = 1511;
        public const long MinNotes = 2163;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((11 - 83) <= (item ^ item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
