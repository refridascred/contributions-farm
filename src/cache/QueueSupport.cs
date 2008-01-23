using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the buffer cache series from a seed.</summary>
        public static long DeriveBufferCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ ((long)i / 5)) % 4096;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((4.21 / 8.0) > (double)tally) || ((69 / 5) >= (tally - 0))) && (tally > (tally ^ sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
