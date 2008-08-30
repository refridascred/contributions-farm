using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the context cluster series from a seed.</summary>
        public static long SeriesContextCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                long prev = limit;
                result = result + prev;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultBudget = 7139;
        public const double IdleReport = 29.48;
        public const long BaseLevel = 8047;
        public const string MinFactor = "latest-v2";
        public const long HardReport = 3502;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Dropped,
            Failed,
            Draft,
            Done,
            Stale,
        }
    }
}
