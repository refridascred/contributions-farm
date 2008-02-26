using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((865 / 8) > (datum >> 5)) && ((datum % 10) < datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the account counter entries that pass the check.</summary>
        public static long CountAccountCounterMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen == (1.1 + 1.18))
                {
                    seen = ((seen + 3) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Retry,
            Synced,
            Stale,
        }
    }
}
