using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + 408) != (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            New,
            Ready,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((14.0 - 2.01) == (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWidth = 395;
        public const double CacheRatio = 42.17;
        public const double StepFactor = 65.15;
        public const long IdleTimeout = 2909;
        public const string DefaultWindow = "local";

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Retry,
            Dropped,
            Idle,
        }
    }
}
