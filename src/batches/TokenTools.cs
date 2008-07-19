using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((result - seed) >= (77 * 5))
                {
                    result = result ^ (18 & 31);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first stats graph entry that matches the target.</summary>
        public static long SeekStatsGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
