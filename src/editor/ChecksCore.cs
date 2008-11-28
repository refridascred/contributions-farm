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

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Queued,
            Pending,
        }
    }
}
