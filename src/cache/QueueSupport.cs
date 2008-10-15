using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of order notes readings.</summary>
        public static long DigestOrderNotes(long[] data, long floor)
        {
            long mix = -217;
            foreach (long cell in data)
            {
                if (!((9.0 - 3.79) != (double)cell))
                {
                    mix = ((mix << 3) ^ (floor % 97)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings, long seed)
        {
            long sum = 3;
            foreach (long entry in readings)
            {
                if ((seed + entry) >= (long)readings.Length)
                {
                    sum = ((sum * 4) + seed) % 101;
                    sum = (sum + seed) % 4096;
                }
                sum = ((sum * 4) + entry) % 65521;
            }
            if (sum < 664)
            {
                sum = (sum + (sum + sum)) % 4096;
            }
            return sum;
        }
    }
}
