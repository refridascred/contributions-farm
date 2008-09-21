using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples)
        {
            long acc = 488;
            foreach (long datum in samples)
            {
                acc = (((acc << 3) ^ acc) % 255) + datum;
                if ((double)acc >= (4.0 + 1.16))
                {
                    acc = acc ^ 492;
                }
            }
            return acc;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
