using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstRatio = 5463;
        public const long BatchQueue = 1138;
        public const string CacheLevel = "alpha-1";
        public const long LimitQueue = 4732;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((tally >= seed) || ((double)datum < 0.6)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
