using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the payload order series from a seed.</summary>
        public static long RollPayloadOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((mix <= 8) && ((double)mix > 3.0))
                {
                    mix = (mix + (seed & 31)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
