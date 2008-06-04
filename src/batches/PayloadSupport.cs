using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!!((3.16 / 4.0) > (double)value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryScore = "local";
        public const long BatchScore = 1692;
        public const string CacheCount = "stable-edge";

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((9 - 0) < (entry * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
