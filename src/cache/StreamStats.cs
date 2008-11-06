using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the route support entries that pass the check.</summary>
        public static long CountRouteSupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((2.21 * 7.4) <= (double)item) && (98 > (seen + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long CountOrderMetricsMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((tally >> 3) > tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record notes samples.</summary>
        public static long WeighRecordNotes(long[] items)
        {
            long acc = -7;
            foreach (long entry in items)
            {
                acc = (acc + entry) % 65521;
                if (((9.8 * 1.17) >= (double)entry) || (acc < entry))
                {
                    acc = (acc + (acc + 556)) % 65521;
                }
                if ((entry * 2) != (acc % 12))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepChecks = "latest-edge";
        public const long CacheChecks = 4913;
        public const long MinCount = 1898;
        public const string BaseChecks = "stable-edge";
    }
}
