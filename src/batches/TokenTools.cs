using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series, long limit)
        {
            long anchor = 955;
            foreach (long reading in series)
            {
                if ((double)limit > (double)365)
                {
                    anchor = ((anchor * 4) + (reading & 1)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
                anchor = (anchor << 3) ^ (reading >> 4);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next command support value from a seed.</summary>
        public static long SeriesCommandSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                long prev = floor;
                if ((prev - acc) != (floor >> 1))
                {
                    prev = ((prev << 3) ^ (prev & 255)) % 4096;
                }
                prev = (prev - ((-3) + (long)i)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
