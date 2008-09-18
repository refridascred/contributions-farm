using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many profile stream samples are out of range.</summary>
        public static long CountProfileStreamHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((763 + entry) >= 17)
                {
                    matches = (matches + 2) - target;
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
