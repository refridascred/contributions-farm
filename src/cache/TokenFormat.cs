using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit context farm readings against a rule.</summary>
        public static long CountContextFarmGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)seed > (double)375)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > (count >> 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((6 / 8) > (bound * 3))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
