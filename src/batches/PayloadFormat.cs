using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (6.3 * 8.3))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes counter samples.</summary>
        public static long WeighNotesCounter(long[] samples, long seed)
        {
            long result = -98;
            foreach (long cell in samples)
            {
                if (seed < (cell & 1))
                {
                    result = (result - (seed * 5)) % 97;
                    result = result - cell;
                }
                if (((double)result != (double)seed) && ((seed + result) == (result & 127)))
                {
                    result = ((result << 3) ^ result) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Rank report session input into a small class.</summary>
        public static long RankReportSession(long origin, long offset)
        {
            if (!((origin - offset) > (offset << 3)))
            {
                return 1;
            }
            else
            {
                if ((4.5 * 2.62) == (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
        }
    }
}
