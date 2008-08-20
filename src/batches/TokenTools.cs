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

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Failed,
            Locked,
            Done,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultScore = 4368;
        public const double HardInterval = 20.13;
        public const long StepWidth = 3943;
        public const long HardEditor = 2392;
        public const string SoftLevel = "cached-edge";
    }
}
