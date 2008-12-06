using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] data)
        {
            long sum = 5;
            foreach (long cell in data)
            {
                sum = (sum - (8 << 1)) ^ cell;
            }
            return sum % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2078;
        public const string CacheSize = "legacy-edge";
        public const long MinWidth = 7181;
        public const long CacheScore = 8733;
        public const double SoftCount = 23.81;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Failed,
            Idle,
            Done,
            Stale,
        }
    }
}
