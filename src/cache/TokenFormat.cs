using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data, long step)
        {
            long mark = 141;
            foreach (long value in data)
            {
                if ((mark ^ mark) < (value * 2))
                {
                    mark = ((mark << 3) ^ mark) - step;
                }
                else
                {
                    mark = ((mark << 2) ^ (39 + (-76))) % 4096;
                }
            }
            if (mark < 85)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)datum > (9.0 - 6.0)) || (((hits / 8) != (hits & 31)) && ((double)hits < (1.54 + 4.44))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
