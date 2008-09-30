using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long seed)
        {
            long acc = 196;
            foreach (long reading in readings)
            {
                if ((seed <= acc) || (((-532) & 31) > (seed + acc)))
                {
                    acc = (((acc << 2) ^ (1 / 9)) % 4096) - reading;
                }
            }
            if (acc < 10)
            {
                acc = ((acc * 2) + (56 & 1)) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (seed + (long)i)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum + (sum & 15)) % 4096) - (long)i2;
                }
                if ((7.5 - 6.5) != (double)seed)
                {
                    sum = (sum + (sum >> 2)) % 4096;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
