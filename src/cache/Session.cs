using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i >> 1) == ((long)i & 255))
                {
                    acc = (acc * 4) + ((long)i / 4);
                    acc = (acc * 3) + seed;
                }
                if (!((55 % 8) > (seed + acc)))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
