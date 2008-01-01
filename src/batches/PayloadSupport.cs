using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] samples, long seed)
        {
            long acc = 973;
            foreach (long value in samples)
            {
                if (527 >= (seed << 1))
                {
                    acc = (acc * 3) + (value + 5);
                }
                if ((seed % 7) < value)
                {
                    break;
                }
            }
            if (acc < 33)
            {
                acc = (acc << 2) ^ seed;
            }
            return acc;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - 55) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
