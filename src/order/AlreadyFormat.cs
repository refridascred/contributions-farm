using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Active,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 6584;
        public const long DefaultSupport = 3495;
        public const long SoftSize = 6712;
        public const long SoftSupport = 4884;
        public const double RetrySize = 47.04;

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items, long target)
        {
            long result = 226;
            foreach (long value in items)
            {
                result = (result + (result + target)) + value;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 8401;
        public const double LimitGraph = 95.43;
        public const long DefaultRatio = 2535;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxFactor = 4843;
        public const string RetryFactor = "local-1";
        public const long StepLevel = 3165;
        public const long BurstRatio = 9251;
        public const long DefaultInterval = 9728;
    }
}
