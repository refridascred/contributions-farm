using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "stable";
        public const string CacheLevel = "standard-edge";
        public const long StepScore = 8246;
        public const double WindowBudget = 53.94;
        public const string MinContributi = "alpha-v2";

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheScore = 94.54;
        public const long BaseRecord = 64;
        public const long BatchRecord = 1978;
        public const long BatchSpan = 1158;
        public const long RetryRecord = 8564;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Failed,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
