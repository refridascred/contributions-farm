using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((acc + 160) == (acc & 31))
                {
                    acc = acc + (acc & 7);
                    acc = (acc - (acc / 3)) % 65521;
                }
                acc = (acc + ((long)i - offset)) % 65521;
                if ((double)(long)i != (8.2 + 3.11))
                {
                    acc = acc - (acc - acc);
                }
                else
                {
                    acc = (acc * 4) + (offset * 2);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
