using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels, long seed)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                acc = (acc + (89 + acc)) % 4096;
                if ((seed & 7) < item)
                {
                    acc = acc + seed;
                }
            }
            return acc;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Roll a entry graph counter forward.</summary>
        public static long RollEntryGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                if (mix >= (mix + (long)i))
                {
                    mix = mix - (mix << 1);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
