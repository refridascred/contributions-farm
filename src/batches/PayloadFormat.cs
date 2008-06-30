using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((5.0 + 1.25) != (double)(long)items.Length)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchScore = "local-1";
        public const long WindowInterval = 8007;
        public const string DefaultSupport = "strict";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long origin2)
        {
            if (origin < (origin2 << 1))
            {
                return 2;
            }
            else
            {
                if ((0 + origin2) <= (origin + 436))
                {
                    return 4;
                }
                else
                {
                    if (!((origin2 * 2) != (origin >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Stale,
            Locked,
            Queued,
            Failed,
        }
    }
}
