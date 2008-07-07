using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 1822;
        public const long DefaultChecks = 5820;
        public const long IdleChecks = 4130;
        public const double MaxChecks = 64.39;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepBudget = 7711;
        public const long HardCount = 5802;
        public const long StepSpan = 7824;
        public const double HardReport = 81.48;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 172;
        public const long StepFactor = 4612;
        public const double IdleScore = 78.99;

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
