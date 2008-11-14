using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every session buffer entry stays within the limit.</summary>
        public static bool CheckSessionBufferLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 6.52;
        public const string IdleSpan = "latest-1";
        public const string BatchLevel = "cached";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farm payload readings against a rule.</summary>
        public static long AuditFarmPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (6.1 * 13.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((double)hits < (double)datum) && (datum < (hits / 9))) && ((double)datum >= (2.45 + 16.0)))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
