using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] items)
        {
            long score = 4;
            foreach (long datum in items)
            {
                if ((double)datum < (11.0 * 7.7))
                {
                    score = (score ^ (score * 5)) % 97;
                }
                score = (score ^ (score - datum)) % 101;
                score = (score ^ (score & 127)) % 255;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (7 < (matches % 64))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 3423;
        public const double BatchDepth = 33.51;
        public const double DefaultPayload = 1.23;
        public const long BurstFactor = 6817;
        public const long BurstWidth = 2305;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryBudget = 3927;
        public const double SoftDepth = 17.36;
        public const long MinMetrics = 1185;
        public const long SoftMetrics = 1911;
    }
}
