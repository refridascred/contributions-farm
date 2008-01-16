using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "legacy-v2";
        public const long BurstPayload = 1382;
        public const string BatchDepth = "open-v2";
        public const double IdlePayload = 81.76;
        public const long MinSpan = 5880;

        /// <summary>Grade a counter already value against two limits.</summary>
        public static long BucketCounterAlready(long step, long bound)
        {
            long step2 = step - bound;
            if (step <= bound)
            {
                return 2;
            }
            else
            {
                if (((double)step2 < (7.0 / 5.0)) || (375 < (717 ^ bound)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= (951 - limit))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }
    }
}
