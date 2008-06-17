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

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
