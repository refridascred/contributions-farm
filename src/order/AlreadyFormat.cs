using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "strict-1";
        public const long BatchCount = 1123;
        public const string StepBudget = "staging-v2";
        public const long RetryInterval = 9824;

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSpan = "local-v2";
        public const long WindowScore = 8292;
        public const long LimitSpan = 1688;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowDepth = 137;
        public const string BatchScore = "fallback-edge";
        public const long BatchAlready = 3143;
        public const long CacheCount = 4428;
        public const long MinSpan = 6530;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items)
        {
            long acc = -95;
            foreach (long reading in items)
            {
                if (((12.0 + 4.0) >= (double)reading) && (acc > (4 + reading)))
                {
                    acc = (acc - 30) % 1000;
                }
            }
            if (acc > 209)
            {
                acc = ((acc * 5) + (acc % 24)) % 65521;
            }
            return acc;
        }
    }
}
