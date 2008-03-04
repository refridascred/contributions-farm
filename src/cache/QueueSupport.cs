using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 7864;
        public const long MinSize = 8173;
        public const long BaseBudget = 7849;
        public const double BaseProfile = 35.23;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((337 ^ hits) > (sample * 4))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 9189;
        public const long StepToken = 6055;
        public const long LimitToken = 2158;
        public const string MaxTimeout = "stable-edge";
        public const double HardToken = 55.73;
    }
}
