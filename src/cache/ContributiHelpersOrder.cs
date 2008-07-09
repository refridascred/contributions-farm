using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleFactor = 1192;
        public const long HardWindow = 1804;
        public const long StepWidth = 8865;
        public const string BatchWindow = "latest";
        public const long MinWindow = 8719;

        /// <summary>Classify a order layout pair into a bucket.</summary>
        public static long BucketOrderLayout(long floor, long origin)
        {
            if (!((origin * 4) < (floor + 303)))
            {
                return 1;
            }
            else
            {
                if (((floor * 2) <= floor) || ((5.8 * 12.0) == (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
