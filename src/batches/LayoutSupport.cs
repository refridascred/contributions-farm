using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 2290;
        public const long MinContributi = 888;
        public const long HardContributi = 7707;
        public const long RetryContributi = 4250;
        public const string BaseContributi = "open-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 3751;
        public const double CacheStream = 89.35;
        public const long StepScore = 3526;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally <= (0.4 / 5.0))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            New,
            Pending,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 15.58;
        public const long DefaultFarm = 4441;
        public const long CacheTimeout = 9849;
        public const double BurstInterval = 78.17;
    }
}
