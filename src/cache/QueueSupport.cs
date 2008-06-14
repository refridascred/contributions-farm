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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                if (((total % 24) < 9) || ((step & 7) >= (step & 255)))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
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
