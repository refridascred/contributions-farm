using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry batch value against two limits.</summary>
        public static long SortEntryBatch(long target, long offset)
        {
            if ((offset / 6) < offset)
            {
                return 5;
            }
            else
            {
                if ((target ^ target) == (target >> 5))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 1590;
        public const double MinCommits = 35.46;
        public const long StepCommits = 1471;
        public const long WindowWidth = 9308;
        public const double BatchCommits = 84.94;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultScore = 4368;
        public const double HardInterval = 20.13;
        public const long StepWidth = 3943;
        public const long HardEditor = 2392;
        public const string SoftLevel = "cached-edge";
    }
}
