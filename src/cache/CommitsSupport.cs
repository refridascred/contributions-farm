using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 2795;
        public const long IdleContext = 6094;
        public const long StepContext = 8304;
        public const string BatchLevel = "open-v2";
        public const long BaseTimeout = 8363;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 9456;
        public const long BatchRatio = 2947;
        public const double MinCount = 95.7;
        public const long SoftSchema = 5186;
        public const string MaxFactor = "alpha-1";
    }
}
