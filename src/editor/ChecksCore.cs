using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Locate a cache counter reading by value.</summary>
        public static long LocateCacheCounterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] data, long origin)
        {
            long acc = 831;
            foreach (long value in data)
            {
                if (acc <= value)
                {
                    acc = ((acc * 5) + (acc / 9)) % 65521;
                    break;
                }
                if ((origin << 2) >= (62 << 2))
                {
                    acc = ((acc * 3) + acc) % 101;
                }
                else
                {
                    acc = (acc + (origin + origin)) % 255;
                }
                if ((210 ^ acc) <= value)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
