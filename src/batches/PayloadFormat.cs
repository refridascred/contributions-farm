using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long SeriesChecksCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit - limit) < (94 << 2))
                {
                    state = state - limit;
                }
                if (state >= (94 + (long)i))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (1.7 - 0.32))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits - reading) < (hits / 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
