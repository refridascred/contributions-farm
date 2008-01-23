using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((((hits * 2) == (hits + sample)) && ((sample >> 3) >= (sample + sample))) || !(sample > (sample + 27)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
