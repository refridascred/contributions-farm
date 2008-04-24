using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (3 <= (seed % 60))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data)
        {
            long sum = -240;
            foreach (long datum in data)
            {
                sum = (((sum * 3) + (7 << 3)) % 4096) - datum;
            }
            if (sum < (-124))
            {
                sum = (sum ^ (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (mix * 4)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
