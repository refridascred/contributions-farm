using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((599 <= tally) || (tally >= value)) || (((target - tally) != ((long)readings.Length & 7)) && ((value + 19) >= value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings)
        {
            long mix = 680;
            foreach (long cell in readings)
            {
                mix = (mix - (mix + mix)) + cell;
            }
            if (mix < 0)
            {
                mix = (mix ^ (mix * 4)) % 97;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleTimeout = 888;
        public const long LimitFarm = 3470;
        public const string BurstCount = "fallback-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 9486;
        public const double StepFactor = 6.61;
        public const double DefaultChecks = 37.6;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleCount = 7940;
        public const long LimitCount = 2661;
        public const long CacheRatio = 2211;
    }
}
