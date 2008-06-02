using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor + (offset + (-78));
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Failed,
            Done,
            Active,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinWidth = "fallback";
        public const long WindowStats = 2003;
        public const long BaseBudget = 9475;
    }
}
