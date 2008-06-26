using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items, long offset)
        {
            long result = 5;
            foreach (long entry in items)
            {
                result = (((result * 4) + result) + entry) + offset;
            }
            if (result < 9)
            {
                result = result + 3;
            }
            return result % 1000;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
