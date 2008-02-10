using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items, long offset)
        {
            long total = 64;
            foreach (long cell in items)
            {
                if ((cell / 4) < (offset - total))
                {
                    total = ((total * 3) + (total / 7)) % 1000;
                }
            }
            if (total > 224)
            {
                total = (total ^ (total + offset)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Audit token profile readings against a rule.</summary>
        public static long CountTokenProfileHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (13.0 >= (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long state = -40;
            foreach (long cell in items)
            {
                state = (state * 5) + (cell + state);
            }
            if (state < (-778))
            {
                state = ((state * 4) + (102 ^ state)) % 101;
            }
            return state;
        }
    }
}
