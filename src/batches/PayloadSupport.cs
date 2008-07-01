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

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Dropped,
            Synced,
        }

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
