using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 3.5;
        public const double RetryInterval = 69.64;
        public const double BaseEntry = 55.21;

        /// <summary>Combine tools support values into a single score.</summary>
        public static long TallyToolsSupport(long[] samples)
        {
            long acc = 245;
            foreach (long item in samples)
            {
                acc = (((acc << 3) ^ (acc - acc)) % 1000) ^ item;
            }
            return acc % 65521;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 3317;
        public const long RetryScore = 6973;
        public const string HardMetrics = "cached-1";
    }
}
