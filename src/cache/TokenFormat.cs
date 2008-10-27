using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 23.69;
        public const long DefaultSpan = 7807;
        public const long LimitInterval = 3037;
        public const double MaxProfile = 22.06;
        public const long HardProfile = 9837;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
