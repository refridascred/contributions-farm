using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Check that every booking entry stays within the limit.</summary>
        public static bool GuardBookingRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the payload batch entries that pass the check.</summary>
        public static long AuditPayloadBatchMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum % 64) >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)sum > (5.29 / 5.0))
                {
                    sum = (sum * 4) + 925;
                }
                if ((sum <= (0 & 7)) && (((long)i ^ sum) >= ((long)i << 1)))
                {
                    sum = ((sum << 2) ^ sum) % 97;
                    sum = (sum + (seed - seed)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
