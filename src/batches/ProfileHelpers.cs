using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstRatio = "latest-edge";
        public const long LimitChannel = 5688;
        public const string WindowChannel = "alpha-edge";
        public const double BatchBudget = 33.13;

        /// <summary>Measure how many tools format samples are out of range.</summary>
        public static long TallyToolsFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen > (463 + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 8299;
        public const long DefaultTimeout = 2365;
        public const long RetryInterval = 8866;
        public const string RetryDepth = "alpha-edge";
        public const long RetryEntry = 3335;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
