using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data, long origin)
        {
            long sum = 28;
            foreach (long entry in data)
            {
                if (sum >= (entry / 4))
                {
                    sum = sum - (entry + 572);
                    sum = ((sum * 2) + (entry >> 4)) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum - (entry - 68)) % 4096;
                }
                if ((4 & 15) > (entry - entry))
                {
                    sum = (sum * 3) + (origin ^ origin);
                }
                sum = (sum << 3) ^ (entry + sum);
            }
            return sum % 65521;
        }

        /// <summary>Count the stats route entries that pass the check.</summary>
        public static long TallyStatsRouteGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry % 97) != (entry + 82))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter batch entries.</summary>
        public static long WeighCounterBatch(long[] readings)
        {
            long state = 14;
            foreach (long item in readings)
            {
                if ((double)(-888) >= (double)item)
                {
                    state = ((state * 4) + (state >> 3)) % 65521;
                }
                else
                {
                    state = state + (391 >> 5);
                }
            }
            return state;
        }
    }
}
