using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate already counter readings against a bound.</summary>
        public static bool GuardAlreadyCounterLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next notes cache value from a seed.</summary>
        public static long SeriesNotesCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((1 > (limit % 10)) || ((carry << 3) <= (limit + carry)))
                {
                    carry = ((carry * 5) + (17 + (long)i)) % 255;
                    carry = ((carry << 2) ^ carry) % 101;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
