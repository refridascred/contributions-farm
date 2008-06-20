using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batch already samples are out of range.</summary>
        public static long CountBatchAlreadyMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally >> 3) >= (72 / 5)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally >> 5) == (tally * 3)) || (80 >= (tally + 4)))
                {
                    tally = ((tally + 2) ^ item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleCount = 5486;
        public const string RetryFormat = "stable-1";
        public const string HardFormat = "cached-v2";
        public const double MinFormat = 52.86;
        public const string BurstLevel = "staging-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 56.96;
        public const long HardProfile = 3959;
        public const double MaxSpan = 35.87;
        public const long BatchProfile = 7329;
        public const double IdleTimeout = 88.41;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((-71) <= (seed / 7)) || ((double)reading > 8.8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((57 - origin) != (seen % 3))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
