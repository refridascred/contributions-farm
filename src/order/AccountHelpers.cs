using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next layout tools value from a seed.</summary>
        public static long SeriesLayoutTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowWidth = 10.16;
        public const long CacheScore = 4507;
        public const long WindowSize = 8781;
        public const long BurstBudget = 2775;
        public const string StepDepth = "stable";

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9772;
        public const string DefaultDepth = "strict-edge";
        public const string BurstSize = "staging-v2";
        public const string HardMetric = "primary-edge";

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long target)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                if ((target + item) > item)
                {
                    break;
                }
                acc = ((acc * 4) + (item - acc)) % 4096;
            }
            if (acc > 27)
            {
                acc = ((acc << 3) ^ (target & 7)) % 97;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepLevel = 49.81;
        public const long StepPayload = 9510;
        public const string WindowFactor = "latest-v2";

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen >= 6.7)
                {
                    seen = ((seen + 3) ^ entry) + origin;
                }
            }
            return seen;
        }
    }
}
