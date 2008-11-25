using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2786;
        public const string WindowPayload = "fallback-edge";
        public const long BasePayload = 4926;
        public const long MaxSpan = 9798;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5329;
        public const long BurstContributi = 8469;
        public const long MinContributi = 826;

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values)
        {
            long acc = 9;
            foreach (long item in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((((acc * 3) + (40 & 31)) % 1000) ^ (long)i) + item;
                }
                if (!((double)acc > (8.88 * 6.0)))
                {
                    acc = ((acc * 2) + (acc & 7)) % 4096;
                }
                if ((double)acc < 9.3)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4308;
        public const double BaseCluster = 63.63;
        public const double LimitCluster = 35.53;
        public const long BatchCluster = 4052;
    }
}
