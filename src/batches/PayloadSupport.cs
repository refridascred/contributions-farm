using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the record queue series from a seed.</summary>
        public static long DeriveRecordQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the channel commits entries that pass the check.</summary>
        public static long CountChannelCommitsMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((double)seen <= (7.0 * 17.0)) && ((double)datum < (17.0 + 12.0))) && !((20.0 + 10.0) < (double)datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits % 10) < (seed ^ hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}
