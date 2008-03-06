using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftSize = 36.09;
        public const long WindowRecord = 4193;
        public const long IdleRecord = 2168;
        public const long MinDepth = 4949;
        public const long HardRecord = 1813;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
