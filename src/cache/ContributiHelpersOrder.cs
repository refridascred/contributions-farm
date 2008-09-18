using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)matches < 20.0) || !((seed + 85) > seed))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples, long limit)
        {
            long total = 512;
            foreach (long reading in samples)
            {
                total = (((total * 5) + total) ^ reading) + limit;
            }
            if (total < 890)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) > (count / 9))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
