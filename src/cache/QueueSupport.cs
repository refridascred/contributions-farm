using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits < reading)
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Done,
            Closed,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((double)seen != (5.01 / 4.0)) || ((seed + reading) >= (seen & 1))) && (((reading / 8) >= (reading & 3)) || ((seed ^ seen) <= (seen + seen))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
